﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReleaseNameManager
{
    public partial class MainForm : Form
    {
        private readonly NameManager _nameManager = new NameManager();
        private readonly IList<ListViewGroup> _listViewGroups = new List<ListViewGroup>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void listViewSubfiles_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Copy : DragDropEffects.None;
        }

        private void listViewSubfiles_DragDrop(object sender, DragEventArgs e)
        {
            string[] droppedFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
            // TODO: Filter only *.srt files.
            foreach (var fileName in droppedFiles)
            {
                _nameManager.Add(new SubtitleFile(fileName));
            }
            GeneratePreview();
        }

        private void GeneratePreview()
        {
            listViewSubfiles.BeginUpdate();
            // Set item to its belonging group + store them into list-view.
            foreach (KeyValuePair<string, HashSet<string>> kvp in _nameManager)
            {
                // TODO: Create friendly group name.
                var listViewGroup = new ListViewGroup(kvp.Key);
                listViewSubfiles.Groups.Add(listViewGroup);
                foreach (string release in kvp.Value)
                {
                    var lvi = new ListViewItem(string.Empty) { Checked = true };
                    lvi.SubItems.Add(release);
                    lvi.Group = listViewGroup;
                    listViewSubfiles.Items.Add(lvi);
                }
                //_listViewGroup.Contains()
                //if(_listViewGroups.Contains()
                //AddToListView(releaseName);
            }
            listViewSubfiles.EndUpdate();
        }

        private void AddToListView(string fileName)
        {
            var listViewItem = new ListViewItem() { Checked = true };
            listViewItem.SubItems.Add(fileName);
            listViewSubfiles.Items.Add(listViewItem);
        }

    }
}
