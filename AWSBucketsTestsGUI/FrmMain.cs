using AWSBucketsTests_DAL;
using Miscellaneous;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace AWSBucketsTestsGUI
{
    public partial class FrmMain : Form
    {
        public string TxtNombre { get; set; }

        private Buckets_DAL bdal;
        private List<String> buckets;

        public FrmMain()
        {
            InitializeComponent();
        }

        private async void FrmMain_Load(object sender, EventArgs e)
        {
            bdal = new Buckets_DAL();
            buckets = new List<String>();
            PrepareUI();
            await LoadBucketList();
        }

        #region Events

        private void BtnSelectPath_Click(object sender, EventArgs e)
        {
            if (Fbd_BasePath.ShowDialog() == DialogResult.OK)
            {
                TbPath.Text = Fbd_BasePath.SelectedPath;
            }
            PrepareUI();
        }


        private void BtnSelectFile_Click(object sender, EventArgs e)
        {
            if (OfdUploadFile.ShowDialog() == DialogResult.OK)
            {
                TbFile.Text = OfdUploadFile.FileName;
            }
            PrepareUI();
        }

        private async void BtnNewBucket_Click(object sender, EventArgs e)
        {
            await ShowFrmTxtDialog(1);
        }

        private async void BtnNewFolder_Click(object sender, EventArgs e)
        {
            await ShowFrmTxtDialog(2);
        }

        private async void lv_buckets_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            await LoadItemsBucketList();
        }

        private void LvItemsBucket_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrepareUI();
        }

        private async void BtnDownloadFile_Click(object sender, EventArgs e)
        {
            await DownloadFile();
        }

        private async void BtnUploadFile_Click(object sender, EventArgs e)
        {
            await UploadFile();
        }

        private async void BtnDeleteFile_Click(object sender, EventArgs e)
        {
            await DeleteFile();
        }

        # endregion

        private void PrepareUI()
        {
            Fbd_BasePath.SelectedPath = Constants.DOWNLOAD_PATH;
            TbPath.Text = Constants.DOWNLOAD_PATH;

            BtnDownloadFile.Enabled = (LvItemsBucket.SelectedItems.Count > 0 && !string.IsNullOrEmpty(TbPath.Text)) ? true : false;
            BtnUploadFile.Enabled = (LvBuckets.SelectedItems.Count > 0 && !string.IsNullOrEmpty(TbFile.Text)) ? true : false;
            BtnDeleteFile.Enabled = (LvBuckets.SelectedItems.Count > 0) ? true : false;
            BtnNewFolder.Enabled = (LvBuckets.SelectedItems.Count > 0) ? true : false;
        }

        private async Task ShowFrmTxtDialog(int type) // 1 = Bucket // 2 = Folder
        {
            FrmTextInput frm = new FrmTextInput() { Parent = this };
            frm.ShowDialog();
            if (!string.IsNullOrEmpty(TxtNombre))
            {   
                if (type == 1)
                {
                    await bdal.CreateBucket(TxtNombre);
                }
                else if (type == 2)
                {
                    await bdal.CreateFolder(LvBuckets.SelectedItems[0].Text, TxtNombre);
                }
                MessageBox.Show("Object Created!");
                await LoadItemsBucketList();
            }
            else
            {
                MessageBox.Show("Write a valid name");
            }
            await LoadBucketList();
        }

        private async Task LoadBucketList()
        {
            DisplayBucketList(await bdal.GetBuckets());
        }

        private async Task LoadItemsBucketList()
        {
            if (LvBuckets.SelectedItems.Count > 0)
            {
                DisplayItemsBucketList(await bdal.GetItemsBucket(LvBuckets.SelectedItems[0].Text));
            }
            PrepareUI();
        }

        private void DisplayBucketList(List<String> bucketList)
        {
            LvBuckets.Items.Clear();
            LvBuckets.Columns.Clear();
            bucketList.ForEach(bucket => { LvBuckets.Items.Add(bucket); });
        }

        private void DisplayItemsBucketList(List<String> itemsList)
        {
            LvItemsBucket.Items.Clear();
            LvItemsBucket.Columns.Clear();
            itemsList.ForEach(item => { LvItemsBucket.Items.Add(item); });
        }

        private async Task DownloadFile()
        {
            if (LvItemsBucket.SelectedItems.Count > 0 && !string.IsNullOrEmpty(TbPath.Text))
            {
                string bucketName = LvBuckets.SelectedItems[0].Text,
                        itemKey = LvItemsBucket.SelectedItems[0].Text,
                        basePath = TbPath.Text;
                await bdal.DownloadItemBucket(bucketName, itemKey, basePath);
                MessageBox.Show("File Downloaded");
            }
            else
            {
                MessageBox.Show("Select a file");
            }

        }

        private async Task UploadFile()
        {
            if (LvBuckets.SelectedItems.Count > 0 && !string.IsNullOrEmpty(TbFile.Text))
            {
                string bucketName = LvBuckets.SelectedItems[0].Text,
                        itemKey = System.IO.Path.GetFileName(OfdUploadFile.FileName),
                        basePath = OfdUploadFile.FileName;
                await bdal.UploadItemBucket(bucketName, itemKey, basePath);
                MessageBox.Show("File Uploaded");
            }
            else
            {
                MessageBox.Show("Select a file");
            }

            TbFile.Text = "";
            OfdUploadFile.FileName = "";
            await LoadItemsBucketList();
        }

        private async Task DeleteFile() {
            if (LvItemsBucket.SelectedItems.Count > 0)
            {
                string bucketName = LvBuckets.SelectedItems[0].Text,
                        itemKey = LvItemsBucket.SelectedItems[0].Text,
                        basePath = TbPath.Text;
                await bdal.DeleteItemBucket(bucketName, itemKey);
                MessageBox.Show("File Deleted");
            }
            else
            {
                MessageBox.Show("Select a file");
            }

            await LoadItemsBucketList();
        }
    }
}