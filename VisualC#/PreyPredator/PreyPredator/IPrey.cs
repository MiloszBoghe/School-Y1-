namespace PreyPredator
{
    public interface IPrey
    {
        Position Position {
            get;
        }

        IPrey Breed();
       
    }

}
