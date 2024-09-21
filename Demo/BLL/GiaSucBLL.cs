using Demo;

public class GiaSucBLL
{
    private GiaSucDAL giaSucDAL = new GiaSucDAL();

    public void SaveGiaSuc(GiaSuc giaSuc)
    {
        giaSucDAL.InsertGiaSuc(giaSuc);
    }

    public void SinhConVaChoSua(GiaSuc giaSuc)
    {
        giaSuc.SinhCon();
        giaSuc.ChoSua();
        SaveGiaSuc(giaSuc);
    }
}
