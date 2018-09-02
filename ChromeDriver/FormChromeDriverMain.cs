using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ChromeDriverAutomation
{
    public partial class FormChromeDriverMain : Form
    {
        private ChromeDriverService chromeDriverService = null;
        private ChromeDriver driver = null;

        public FormChromeDriverMain()
        {
            InitializeComponent();
                chromeDriverService = ChromeDriverService.CreateDefaultService(@"E:\ChromeAuto\ChromeDriver\packages\Selenium.WebDriver.ChromeDriver.2.41.0\driver\win32\", "chromedriver.exe");
                chromeDriverService.HideCommandPromptWindow = true;
                driver = new ChromeDriver(chromeDriverService, new ChromeOptions());
        }

        private void FormChromeDriverMain_Load(object sender, EventArgs e)
        {
            this.radioActionByID.Checked = true;
            this.cbbActionIDType.SelectedIndex = 0;
        }

        private void btnLoadWebsite_Click(object sender, EventArgs e)
        {
            try
            {
                driver.Navigate().GoToUrl(this.txtAddressText.Text);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }

        private void FormChromeDriverMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.driver != null)
            {
                try
                {
                    this.driver.Close();
                }
                catch
                {

                }
            }
            if(this.chromeDriverService != null)
            {
                try
                {
                    this.chromeDriverService.Dispose();
                }
                catch
                {

                }
            }
        }

        private void btnGetElementByID_Click(object sender, EventArgs e)
        {
            try
            {
                String actionType = this.cbbActionIDType.SelectedItem.ToString();

                switch (actionType)
                {
                    case "GET":
                        getAttributeByID(this.cbbAttribute.Text);
                        break;
                    case "SET":
                        setValueByID();
                        break;
                    case "CLICK":
                        clickElementByID();
                        break;
                    default: break;
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }

        private void getAttributeByID(String attributeName)
        {
            IWebElement element = this.driver.FindElementById(this.txtIDInputCheck.Text);

            if (element != null)
            {
                MessageBox.Show(element.GetAttribute(attributeName).ToString());
            }
        }

        private void setValueByID()
        {
            IWebElement element = this.driver.FindElementById(this.txtIDInputCheck.Text);

            if (element != null)
            {
                element.SendKeys(this.txtValueByID.Text);
            }
        }

        private void clickElementByID()
        {
            IWebElement element = this.driver.FindElementById(this.txtIDInputCheck.Text);

            if (element != null)
            {
                element.Click();
            }
        }

        private void btnGetElementByClass_Click(object sender, EventArgs e)
        {
            try
            {
                String actionType = this.cbbActionClassType.SelectedItem.ToString();

                switch (actionType)
                {
                    case "GET":
                        getAttributeByClass(this.cbbAttribute.Text);
                        break;
                    case "SET":
                        setValueByClass();
                        break;
                    case "CLICK":
                        clickElementByClass();
                        break;
                    default: break;
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }

        private void getAttributeByClass(String attributeName)
        {
            ReadOnlyCollection<IWebElement> elementCollections = this.driver.FindElementsByClassName(this.txtInputClassCheck.Text);

            if (elementCollections != null)
            {
                int i = 1;
                foreach (IWebElement element in elementCollections) {
                    if (Convert.ToString(i).Equals(this.txtPosition.Text))
                    {
                        this.txtLogMonitorWeb.AppendText(element.GetAttribute(attributeName).ToString() + "\r\n");
                        break;
                    }
                    this.txtLogMonitorWeb.AppendText(element.GetAttribute(attributeName).ToString() + "\r\n");
                    i++;
                }
            }
        }

        private void setValueByClass()
        {
            ReadOnlyCollection<IWebElement> elementCollections = this.driver.FindElementsByClassName(this.txtInputClassCheck.Text);

            if (elementCollections != null)
            {
                int i = 1;
                foreach (IWebElement element in elementCollections)
                {
                    if(Convert.ToString(i).Equals(this.txtPosition.Text))
                    {
                        element.SendKeys(this.txtValueByClass.Text);
                        break;
                    }
                    i++;
                }
            }
        }

        private void clickElementByClass()
        {
            ReadOnlyCollection<IWebElement> elementCollections = this.driver.FindElementsByClassName(this.txtInputClassCheck.Text);

            if (elementCollections != null)
            {
                int i = 1;
                foreach (IWebElement element in elementCollections)
                {
                    if (Convert.ToString(i).Equals(this.txtPosition.Text))
                    {
                        element.Click();
                        break;
                    }
                    i++;
                }
            }
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            this.txtLogMonitorWeb.Clear();
        }

        private void btnActionByTagName_Click(object sender, EventArgs e)
        {
            try
            {
                String actionType = this.cbbTagNameEvent.SelectedItem.ToString();

                switch (actionType)
                {
                    case "GET":
                        getAttributeByTagName(this.cbbAttribute.Text);
                        break;
                    case "SET":
                        setValueByTagName();
                        break;
                    case "CLICK":
                        clickElementByTagName();
                        break;
                    default: break;
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }

        private void getAttributeByTagName(String attributeName)
        {
            ReadOnlyCollection<IWebElement> elementCollections = this.driver.FindElementsByTagName(this.txtTagName.Text);

            if (elementCollections != null)
            {
                int i = 1;
                foreach (IWebElement element in elementCollections)
                {
                    if (Convert.ToString(i).Equals(this.txtPosition.Text))
                    {
                        this.txtLogMonitorWeb.AppendText(element.GetAttribute(attributeName).ToString() + "\r\n");
                        break;
                    }
                    this.txtLogMonitorWeb.AppendText( i + "-" + element.GetAttribute(attributeName).ToString() + "\r\n");
                    i++;
                }
            }
        }

        private void setValueByTagName()
        {
            ReadOnlyCollection<IWebElement> elementCollections = this.driver.FindElementsByTagName(this.txtTagName.Text);

            if (elementCollections != null)
            {
                int i = 1;
                foreach (IWebElement element in elementCollections)
                {
                    if (Convert.ToString(i).Equals(this.txtPosition.Text))
                    {
                        element.SendKeys(this.txtTagNameValue.Text);
                        break;
                    }
                    i++;
                }
            }
        }

        private void clickElementByTagName()
        {
            ReadOnlyCollection<IWebElement> elementCollections = this.driver.FindElementsByTagName(this.txtTagName.Text);

            if (elementCollections != null)
            {
                int i = 1;
                foreach (IWebElement element in elementCollections)
                {
                    if (Convert.ToString(i).Equals(this.txtPosition.Text))
                    {
                        element.Click();
                        break;
                    }
                    i++;
                }
            }
        }

        private void cbbActionIDType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtPosition.Enabled = false;
                Object o =  this.cbbActionIDType.SelectedItem;

                if(o != null && "GET".Equals(o))
                {
                    this.txtValueByID.Enabled = false;
                    this.txtPosition.Enabled = false;
                    this.cbbAttribute.Enabled = true;
                }
                else if (o != null && "SET".Equals(o))
                {
                    this.txtValueByID.Enabled = true;
                    this.txtPosition.Enabled = false;
                    this.cbbAttribute.Enabled = false;
                }
                else
                {
                    this.txtValueByID.Enabled = false;
                    this.txtPosition.Enabled = false;
                    this.cbbAttribute.Enabled = false;
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }

        private void cbbActionClassType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Object o = this.cbbActionClassType.SelectedItem;

                if (o != null && "GET".Equals(o))
                {
                    this.txtValueByClass.Enabled = false;
                    this.txtPosition.Enabled = false;
                    this.cbbAttribute.Enabled = true;
                    this.txtPosition.Enabled = true;
                }
                else if (o != null && "SET".Equals(o))
                {
                    this.txtValueByClass.Enabled = true;
                    this.txtPosition.Enabled = false;
                    this.cbbAttribute.Enabled = false;
                    this.txtPosition.Enabled = true;
                }
                else
                {
                    this.txtValueByClass.Enabled = false;
                    this.txtPosition.Enabled = false;
                    this.cbbAttribute.Enabled = false;
                    this.txtPosition.Enabled = true;
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }

        private void cbbTagNameEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Object o = this.cbbTagNameEvent.SelectedItem;

                if (o != null && "GET".Equals(o))
                {
                    this.txtTagNameValue.Enabled = false;
                    this.txtPosition.Enabled = false;
                    this.cbbAttribute.Enabled = true;
                    this.txtPosition.Enabled = true;
                }
                else if (o != null && "SET".Equals(o))
                {
                    this.txtTagNameValue.Enabled = true;
                    this.txtPosition.Enabled = false;
                    this.cbbAttribute.Enabled = false;
                    this.txtPosition.Enabled = true;
                }
                else
                {
                    this.txtTagNameValue.Enabled = false;
                    this.txtPosition.Enabled = false;
                    this.cbbAttribute.Enabled = false;
                    this.txtPosition.Enabled = true;
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }

        private void radioActionByID_CheckedChanged(object sender, EventArgs e)
        {
            if(this.radioActionByID.Checked)
            {
                this.txtPosition.Enabled = false;
                this.cbbActionIDType.Enabled = true;
                this.cbbActionClassType.Enabled = false;
                this.cbbTagNameEvent.Enabled = false;

                this.txtIDInputCheck.Enabled = true;
                this.txtInputClassCheck.Enabled = false;
                this.txtTagName.Enabled = false;

                this.txtTagNameValue.Enabled = false;
                this.txtValueByClass.Enabled = false;
            }
        }

        private void radioActionByTagName_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioActionByTagName.Checked)
            {
                this.cbbActionIDType.Enabled = false;
                this.cbbActionClassType.Enabled = false;
                this.cbbTagNameEvent.Enabled = true;

                this.txtIDInputCheck.Enabled = false;
                this.txtInputClassCheck.Enabled = false;
                this.txtTagName.Enabled = true;

                this.cbbTagNameEvent.SelectedIndex = 0;
            }
        }

        private void radioActionByClass_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioActionByClass.Checked)
            {
                this.cbbActionIDType.Enabled = false;
                this.cbbActionClassType.Enabled = true;
                this.cbbTagNameEvent.Enabled = false;

                this.txtIDInputCheck.Enabled = false;
                this.txtInputClassCheck.Enabled = true;
                this.txtTagName.Enabled = false;

                this.cbbActionClassType.SelectedIndex = 0;
            }
        }
    }
}