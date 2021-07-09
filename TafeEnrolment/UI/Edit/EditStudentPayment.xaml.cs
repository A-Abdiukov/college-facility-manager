﻿using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace UI.Edit
{
    /// <summary>
    /// Interaction logic for EditStudentPayment.xaml
    /// </summary>
    public partial class EditStudentPayment : Window
    {
        private readonly List<BusinessLayer.Student> allStudents = new List<BusinessLayer.Student>();

        /// <summary>
        /// Initialises the page.
        /// The comboboxes(students, genders) are filled from Control.cs
        /// methods GetStudents(), GetGenders() respectively.
        /// allStudents, allGenders are filled from Control.cs methods GetStudents(), GetGenders() methods respectively.
        /// </summary>
        public EditStudentPayment()
        {
            InitializeComponent();
            allStudents = App.logic.SortStudentList((List<BusinessLayer.Student>)App.logic.GetFromDB("GetStudents"));
            ComboBoxSelectStudent.ItemsSource = allStudents;
        }

        /// <summary>
        /// When the arrow button (located top left) is clicked, user is redirected to main menu
        /// </summary>
        private void GoBack_navigation_btn_Click(object sender, RoutedEventArgs e)
        {
            GoBack();
        }

        /// <summary>
        /// Redirects the user to the main menu
        /// </summary>
        private void GoBack()
        {
            PageNavigation.GoToExistingPage(0, this);
        }

        /// <summary>
        /// When the page on the navigation bar at the top is clicked upon, this page gets hidden and the user is redirected to that page
        /// </summary>
        private void DgNavigationBar_NavigateToSelectedPage(object sender, DataGridPreparingCellForEditEventArgs e)
        {
            DgNavigationBar.CancelEdit();
            PageNavigation.GoToExistingPage(DgNavigationBar.SelectedIndex, this);
        }

        /// <summary>
        /// Updates the navigation bar at the top, whenever the window visibility changes
        /// </summary>
        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                DgNavigationBar.ItemsSource = null;
                DgNavigationBar.ItemsSource = App.pagesVisitedTracker;
            }
        }

        /// <summary>
        /// When user selects one of students in the combobox, all the textboxes get filled and the gender combobox gets filled as well.
        /// </summary>
        private void ComboBoxSelectStudent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BusinessLayer.Student selectedStudent = (BusinessLayer.Student)ComboBoxSelectStudent.SelectedItem;
            DgStudentEnrolment.ItemsSource = App.logic.GetFromDB("GetEnrolmentsByID", new object[] { selectedStudent.Id });
        }


        private void DgStudentEnrolment_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            DataGridSettings page = new DataGridSettings(DgStudentEnrolment);
            page.Show();
        }

        private void BtnEditPayment_Click(object sender, RoutedEventArgs e)
        {
            BusinessLayer.Enrolment selectedPaymentToChange = (BusinessLayer.Enrolment)DgStudentEnrolment.SelectedItem;
            double amountPaid = 0;
            double amountDue = 0;
            string outcome = App.logic.ManageDB("EditStudentPayment", new object[] { selectedPaymentToChange.CourseStudentID, amountPaid, amountDue });
            MessageBox.Show(outcome);

            GoBack();
        }
    }
}
