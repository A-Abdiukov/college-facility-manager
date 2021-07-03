﻿using System.Windows;
using System.Windows.Controls;

namespace UI
{
    public partial class CourseInformation : Window
    {
        //INITIALISATION CODE
        public CourseInformation()
        {
            InitializeComponent();
        }
        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                DgNavigationBar.ItemsSource = null;
                DgNavigationBar.ItemsSource = App.pagesVisitedTracker;
            }
        }
        //END OF INITIALISATION CODE


        //PAGE NAVIGATION CODE
        private void courseTimetables_navigation_btn_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            PageNavigation.GoToNewOrExistingPage(new CourseTimetableSearch());
        }

        private void clusterUnitCourse_navigation_btn_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            PageNavigation.GoToNewOrExistingPage(new SubjectsClustered());
        }

        private void courseNotOffered_navigation_btn_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            PageNavigation.GoToNewOrExistingPage(new CourseNotOffered());
        }

        private void subjectsNotAllocated_navigation_btn_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            PageNavigation.GoToNewOrExistingPage(new SubjectsWithNoCourse());
        }

        private void GoBack_navigation_btn_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            PageNavigation.GoToExistingPage(new MainWindow());
        }

        private void DgNavigationBar_NavigateToSelectedPage(object sender, DataGridPreparingCellForEditEventArgs e)
        {
            DgNavigationBar.CancelEdit();
            Hide();
            PageNavigation.GoToExistingPage(DgNavigationBar.SelectedIndex);
        }
        //END OF PAGE NAVIGATION CODE
    }
}
