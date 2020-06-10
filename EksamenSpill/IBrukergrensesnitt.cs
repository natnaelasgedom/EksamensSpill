namespace EksamenSpill
{
    public interface IBrukergrensesnitt
    {
        void giStatus(string status);
        int beOmKommando(string spørsmål, string[] alternativet);
    }
}
