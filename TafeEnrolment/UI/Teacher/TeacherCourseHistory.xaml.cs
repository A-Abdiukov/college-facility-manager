﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using UI.Teacher;

namespace UI
{
    public partial class TeacherCourseHistory : Window
    {
        //INITIALISATION CODE
        public TeacherCourseHistory()
        {
            InitializeComponent();
        }

        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                dgBreadcrmbs.ItemsSource = null;
                dgBreadcrmbs.ItemsSource = MainWindow.pagesVisitedTracker;
            }
        }

        //END OF INITIALISATION CODE


        //NAVIGATION CODE

        private void dgBreadcrmbs_NavigateToSelectedPage(object sender, DataGridPreparingCellForEditEventArgs e)
        {
            dgBreadcrmbs.CancelEdit();
            Hide();
            PageNavigation.GoToExistingPage(dgBreadcrmbs.SelectedIndex);
        }

        private void goBack_navigation_btn_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            PageNavigation.GoToNewOrExistingPage(new TeacherProfile());
        }

        //END OF NAVIGATION CODE

        //SEARCH DATAGRID CODE

        private void SearchBox_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            SearchBox.Text = PageLogic.SearchBoxReplaceDefaultValue(SearchBox.Text);
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            PageLogic.SearchTeacherCourseHistory(SearchBox.Text, checkbox_SearchPastCourse.IsChecked, checkbox_SearchPresentCourse.IsChecked);
        }

        private void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                PageLogic.SearchTeacherCourseHistory(SearchBox.Text, checkbox_SearchPastCourse.IsChecked, checkbox_SearchPresentCourse.IsChecked);
            }
        }

        //END OF SEARCH DATAGRID CODE

        //DATAGRID SETTINGS CODE

        private void dgCourseHistory_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            //code for changing the datagrid settings
            MessageBox.Show("Upon right clicking, there should be datagrid settings displayed to user");
        }

        //END OF DATAGRID SETTINGS CODE

    }
}
