using DVLD.UserControls;
using System;
using System.Windows.Forms;

namespace DVLD.Pop_Ups
{
    public partial class Show_Person_Details : Form
    {
        public Show_Person_Details(int personId)
        {
            InitializeComponent();
            LoadPersonDetails(personId);
        }

        private void LoadPersonDetails(int personId)
        {
            personDetailsCard.SetPerson(personId);
        }
    }
}