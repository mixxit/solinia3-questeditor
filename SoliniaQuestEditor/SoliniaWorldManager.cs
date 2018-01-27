namespace SoliniaQuestEditor
{
    public class SoliniaWorldManager
    {
        private frmMain _frmMain;
        public ISoliniaDatabase Database { get; set; }

        public SoliniaWorldManager(frmMain frmMain, string jsonPath)
        {
            _frmMain = frmMain;
            Database = new SoliniaDatabaseJSON(jsonPath);
        }
    }
}