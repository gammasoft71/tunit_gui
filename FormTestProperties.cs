﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tunit {
  public partial class FormTestProperties : Form {
    public FormTestProperties() {
      InitializeComponent();
    }
    public FormTestProperties(string testName, string testFixtureName, string file, TestStatus testStatus, string[] message, string stackTrace, TimeSpan duration) {
      InitializeComponent();
      this.Text = $"{testFixtureName}::{testName} properties";
      this.labelTestName.Text = testName;
      this.labelTestFixtureName.Text = testFixtureName;
      switch (testStatus) {
        case TestStatus.NotStarted:
          this.pictureBoxStatus.Image = tunit.Properties.Resources.NotStarted;
          this.labelStatus.Text = "Not Started";
          break;
        case TestStatus.Succeed:
          this.pictureBoxStatus.Image = tunit.Properties.Resources.Succeed;
          this.labelStatus.Text = "Succeed";
          break;
        case TestStatus.Ignored:
          this.pictureBoxStatus.Image = tunit.Properties.Resources.Ignored;
          this.labelStatus.Text = "Ignored";
          break;
        case TestStatus.Aborted:
          this.pictureBoxStatus.Image = tunit.Properties.Resources.Aborted;
          this.labelStatus.Text = "Aborted";
          break;
        case TestStatus.Failed:
          this.pictureBoxStatus.Image = tunit.Properties.Resources.Failed;
          this.labelStatus.Text = "Failed";
          break;
        default:
          break;
      }
      this.richTextBoxFile.Text = file;
      this.richTextBoxResult.Lines = message;
      this.richTextBoxStackTrace.Text = stackTrace;
      this.labelTime.Text = duration.ToString();
    }
  }
}