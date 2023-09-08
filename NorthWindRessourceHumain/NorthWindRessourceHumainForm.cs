/*
 Programmeur : Chihab Eddine Rouibi 
 Date        : 25 janvier 2023
 But         : Devoir 1 Phase 4
               Produire une application d'acces au donner sous Ado.net pour consulter les employees de NorthWind et changer l 'order 
               a traver un toolStripMenuItems asc/desc.

info :      Base de donnees : Northwind local 
            Table           : Employee , 
            Champs          : emplyeeID ,FirstName , LastName, Title, BirthDate, HireDate, CodePostal, picture,firstName ,lastName. 

 */
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using static NorthWindRessourceHumain.NorthwindDataSet;


namespace NorthWindRessourceHumain
{
    public partial class NorthWindRessourceHumainForm : Form
    {
        #region Constructor
        public NorthWindRessourceHumainForm()
        {
            InitializeComponent();
        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();

        }

        private void NorthWindRessourceHumainForm_Load(object sender, EventArgs e)
        {
            /* SELECT Employees.EmployeeID AS Numero, Employees.LastName AS [Nom de la famille], Employees.FirstName AS Prenom, Employees.Title AS Fonction, Employees.BirthDate AS [Date de naissances], Employees.HireDate AS [Date d'embauche'], 
            Employees.Photo, Employees_1.LastName AS[Nom du superviseur], Employees_1.FirstName AS[Prenom superviseur]
            FROM Employees LEFT OUTER JOIN
            Employees AS Employees_1 ON Employees.ReportsTo = Employees_1.EmployeeID
            WHERE(Employees.PostalCode LIKE N'9%')*/
            try
            {
                this.employeesTableAdapter.Fill(this.northwindDataSet.Employees);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion 

        #region Filter

        private void filterageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sender == tousVendeursToolStripMenuItem)

                employeesBindingSource.Filter = "[Fonction] = 'Sales representative'";

            else if (sender == tousSansSupervisuerToolStripMenuItem)

                employeesBindingSource.Filter = "[Prenom Superviseur] IS NULL";

            else if (sender == dossierTousToolStripMenuItem)
            {
                employeesBindingSource.RemoveFilter();
            }
        }

        #endregion

        #region imprimer
        private void imprimerToolStripButton_Click(object sender, EventArgs e)
        {
            foreach (DataRowView oDataRowView in employeesBindingSource)
            {
             
                Console.WriteLine(String.Format("{0,-10}{1,-25}{2}", oDataRowView["Numero"], oDataRowView["Nom de la famille"], oDataRowView["Prenom"]));

            }
        }
        #endregion

        #region Constants

        //Declaration des constantes 
        const int MAX_YEAR = 1994;
        const int MIN_YEAR = 1992;
        const String TITRE_SRT = "Filtrer les dossier des employees";

        #endregion

        #region validate date
        private Boolean DateEmbaucheValide(String anneeEmbauche, ref String messageAnneeInvalide)
        {
            Boolean validationDate = false;
            int val;
            if (anneeEmbauche != String.Empty)
            {
                if (int.TryParse(anneeEmbauche, out val))
                {
                    if (anneeEmbauche.Length == 4)
                    {
                        if (val >= MIN_YEAR && val <= MAX_YEAR)
                        {
                            validationDate = true;
                        }
                        else
                        {
                            messageAnneeInvalide = String.Format("vous devez entrer une annee entre {0} et {1} ", MIN_YEAR, MAX_YEAR);
                            validationDate = false;
                        }
                    }
                    else
                    {
                        messageAnneeInvalide = " l'annee est un nombre de 4 chiffres";
                        MessageBox.Show(messageAnneeInvalide);
                        validationDate = false;
                    }
                }
                else
                {
                    messageAnneeInvalide = "l'annee de la date doit etre une valeur entrier ";
                    MessageBox.Show(messageAnneeInvalide);
                    validationDate = false;
                }
            }
            else
            {
                messageAnneeInvalide = "l'annee est obligatoire ";
                MessageBox.Show(messageAnneeInvalide);
                validationDate = false;
            }
            return validationDate;
        }

        #endregion

        #region Filtre par nom, function, date
        private void triParNomFonctionDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String questionStr, reponseStr;

            questionStr = "Flitrer les employees dont {0}";

            if (sender == NomFamilleToolStripMenuItem)
                questionStr = String.Format(questionStr, "le nom de famille contient le ou les caracteres suivants :");
            else if (sender == parFonctionToolStripMenuItem)
                questionStr = String.Format(questionStr, "la fonction est :");
            else if (sender == dateEmbaucheToolStripMenuItem)
                questionStr = String.Format(questionStr, "la date s'embauche est de l'annee :");

            reponseStr = Interaction.InputBox(questionStr, TITRE_SRT).Trim();


                if (sender == NomFamilleToolStripMenuItem)
                {
                    employeesBindingSource.Filter = String.Format("[Nom de la famille] LIKE '%{0}%'", reponseStr);
                }
                else if (sender == parFonctionToolStripMenuItem)
                {
                    employeesBindingSource.Filter = String.Format("Fonction ='{0}'", reponseStr);
                }
                else if (sender == dateEmbaucheToolStripMenuItem)
                {
                    String messagesErreurDateStr = String.Empty;
                    if (DateEmbaucheValide(reponseStr, ref messagesErreurDateStr))
                    {
                        employeesBindingSource.Filter = String.Format("[Date d'embauche'] >= '{0}-01-01' AND [Date d'embauche'] <= '{0}-12-31' ", reponseStr);
                    }
                    else
                    {
                        MessageBox.Show(messagesErreurDateStr, TITRE_SRT);
                    }
                }
            
        }
        #endregion

        #region phase 4
        private void orderAscDescToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String order;

            if (sender == superviseurToolStripMenuItem)
            {
                order = "[Nom du superviseur] DESC , [Prenom superviseur] DESC ";
                // employeesBindingSource.Filter = "ORDER BY [Nom du superviseur] ASC";
                employeesBindingSource.Sort = order;
            }
            else if (sender == fonctionToolStripMenuItem)
            {
                order = "[Fonction] ASC , [Nom de la famille] DESC , Prenom DESC";
                employeesBindingSource.Sort = order;
            }
            else if (sender == dateToolStripMenuItem)
            {
                order = "[Date d'embauche'] ASC";
                employeesBindingSource.Sort = order;
            }
            else if (sender == originalToolStripMenuItem)
            {
                employeesBindingSource.RemoveSort();
            }
        }
        #endregion
    }
}
