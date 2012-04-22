using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TikzEdt.DynPreamble;
using TikzEdt;

namespace TikzEdtWForms
{
    public partial class DynamicPreamble : UserControl
    {
        DynPreambleVM TheVM;

        #region properties

        string _PreamblesFile = null;
        /// <summary>
        /// The path to the xml file in which the preambles are stored.
        /// </summary>
        public string PreamblesFile
        {
            get { return _PreamblesFile; }
            set { 
                _PreamblesFile = value;
                if (_PreamblesFile != null)
                    TheVM.LoadPreambles(_PreamblesFile);
            }
        }

        public string Preamble
        {
            get { return TheVM.Preamble; }
        }
        public event EventHandler PreambleChanged;

        #endregion

        public DynamicPreamble()
        {
            InitializeComponent();
            txtPreamble.SetHighlighting("Tikz");
            txtPreamble.IsReadOnly = true;


            // setup bindings
            TheVM = new DynPreambleVM( vm => DynPreambleDialog.ShowDynPreambleDialog(this.ParentForm, vm));

            cmdAdd.Click += (s, e) => TheVM.AddCommand.Execute(null);
            cmdRemove.Click += (s, e) => TheVM.DeleteCommand.Execute(null);
            cmdUp.Click += (s, e) => TheVM.MoveUpCommand.Execute(null);
            cmdDown.Click += (s, e) => TheVM.MoveDownCommand.Execute(null);
            cmdEdit.Click += (s, e) => TheVM.EditCommand.Execute(null);

            BindingFactory.CreateBinding(TheVM, "Preamble", 
                vm => { 
                    txtPreamble.Text = vm.Preamble; 
                    txtPreamble.Refresh();
                    if (PreambleChanged != null)
                        PreambleChanged(this, new EventArgs());
                }, () => txtPreamble.Text = "<unavailable>");
            BindingFactory.CreateIListBinding(TheVM.ElementList, lstItems.Items,
                (DynPreambleElementVM i) => CreateItemFromVM(i),
                (ListViewItem lvi) => (lvi as ListViewItem).Tag as DynPreambleElementVM);

            BindingFactory.CreateBinding(TheVM, "CurrentIndex",
                        vm => {
                            if (vm.CurrentIndex >= 0 && vm.CurrentIndex < lstItems.Items.Count)
                                lstItems.Items[vm.CurrentIndex].Selected = true;
                            else foreach (var i in lstItems.Items.OfType<ListViewItem>())
                                    i.Selected = false;
                        },
                        null);
            lstItems.SelectedIndexChanged += (s, e) => TheVM.CurrentIndex = lstItems.SelectedIndices.Count > 0 ? lstItems.SelectedIndices[0] : -1;

            this.HandleDestroyed  += (o, e) => { if (PreamblesFile != null) TheVM.SavePreambles(PreamblesFile); };
            
        }

        ListViewItem CreateItemFromVM(DynPreambleElementVM vm)
        {
            var ret = new ListViewItem() { Tag = vm };
            ret.SubItems.Add("");

            BindingFactory.CreateBinding(vm, "Name", v => { ret.Text = v.Name; }, () => ret.Text="<Error>", false);
            BindingFactory.CreateBinding(vm, "Code", v => { ret.SubItems[1].Text = v.CodeOneLine; }, () => ret.SubItems[1].Text="<Error>", false);
            ret.Checked = vm.IsActive;

            return ret;
        }

        private void lstItems_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item != null && e.Item.Tag is DynPreambleElementVM)
                ((DynPreambleElementVM)e.Item.Tag).IsActive = e.Item.Checked;
        }
    }
}
