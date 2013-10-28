using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace VocabularyCard
{
    public partial class MainPage : PhoneApplicationPage
    {
        // 首頁的 URL
        private string MainUri = "/Html/index.html";

        // 建構函式
        public MainPage()
        {
            InitializeComponent();
        }

        private void Browser_Loaded(object sender, RoutedEventArgs e)
        {
            // 在此加入您的 URL
            Browser.Navigate(new Uri(MainUri, UriKind.Relative));
            Browser.IsScriptEnabled = true;
        }

        // 在網頁瀏覽器的巡覽堆疊而非應用程式中向後巡覽。
        private void BackApplicationBar_Click(object sender, EventArgs e)
        {
            Browser.GoBack();
        }

        // 在網頁瀏覽器的巡覽堆疊而非應用程式中向前巡覽。
        private void ForwardApplicationBar_Click(object sender, EventArgs e)
        {
            Browser.GoForward();
        }

        // 巡覽至初始「首頁」。
        private void HomeMenuItem_Click(object sender, EventArgs e)
        {
            Browser.Navigate(new Uri(MainUri, UriKind.Relative));
        }

        // 處理巡覽失敗。
        private void Browser_NavigationFailed(object sender, System.Windows.Navigation.NavigationFailedEventArgs e)
        {
            MessageBox.Show("巡覽至此頁面失敗，請檢查網際網路連線");
        }
    }
}