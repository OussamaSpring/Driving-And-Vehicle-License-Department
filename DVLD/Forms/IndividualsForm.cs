using Core.Models;
using DVLD.UserControls;
using DVLD_BusinessLogic;
using DVLD_DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Forms
{
    public partial class IndividualsForm : Form
    {
        private PersonController _personController;
        public IndividualsForm()
        {
            InitializeComponent();

            _personController = new PersonController(new PersonRepository());


            var tabs = new TabBar
            {
                Dock = DockStyle.Fill,
                Height = 50
            };
            tabs.SetTabs("People", "Drivers");
            tabs.SelectedIndexChanged += (s, e) =>
            {
                switch (tabs.SelectedIndex)
                {
                    case 0:
                        OnPeopleTabSelected();
                        break;
                    case 1:
                        OnDriversTabSelected();
                        break;
                }
            };

            tlp_header.Controls.Add(tabs, 1, 0);


        }

        private void IndividualsForm_Load(object sender, EventArgs e)
        {
            OnPeopleTabSelected();
        }
        private async void OnPeopleTabSelected()
        {
            htc_tab_nav.SelectedIndex = 0; // Select the "People" tab
            await LoadPeopleAsync();
        }

        private void OnDriversTabSelected()
        {
            htc_tab_nav.SelectedIndex = 1; // Select the "Drivers" tab
        }



        private async Task LoadPeopleAsync()
        {
            var people = await _personController.GetPeopleListAsync();

            dgv_people.Rows.Clear();

            foreach (Person person in people)
            {
                dgv_people.Rows.Add(
                    person.PersonId,
                    person.NationalNumber,
                    person.FirstName,
                    person.SecondName,
                    person.ThirdName,
                    person.LastName,
                    person.enGender == Core.Enums.Gender.Male ? "Male" : "Female",
                    person.DateOfBirth.ToString("yyyy/M/dd"),
                    person.NationalityCountry,
                    person.Phone,
                    person.Email
                    );
            }


        }
    }
}
