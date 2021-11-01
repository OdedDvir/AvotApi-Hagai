namespace PuzzlesoftApi.Model
{
    public class pr_RetDataToClientToShikumModel
    {
        public Table1[] Table;
        public Table2[] Table1;
        public Table3[] Table2;
        public Table3[] Table3;
        public Table3[] Table4;
        public Table3[] Table5;
        public Table3[] Table6;
        public Table3[] Table7;
        public Table3[] Table8;
        public Table4[] Table9;
    }

    public class Table1
    {
        public string ClientId;
        public string FName;
        public string LName;
        public string IDCard;
        public string Gender;
        public string Age2;
        public string Kupa;
        public string DateNeedEnter;
        public string DtFree_DtCngStt;
    }

    public class Table2
    {
        public string Avhanakod;
        public string Status;
        public string DateS;
        public string DateE;
        public string tStamp;
        public string UserCreate;
        public string AvhanaFull;
    }

    public class Table3
    {
        public string Cap1;
        public string Id;
        public string TypeForm;
        public string DoctorName;
        public string val1;
        public string Val2;
        public string UserCreate;
        public string Subject1;
        public string DateNTime;
    }

    public class Table4
    {
        public string ID;
        public string Item;
        public string FollowKey;
        public string OrderID;
        public string Val1;
        public string bDel;
        public string Kod1;
    }
}