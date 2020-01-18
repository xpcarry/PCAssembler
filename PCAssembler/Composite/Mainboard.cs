namespace PCAssembler
{
    internal class Mainboard : Component
    {
        public override int Count()
        {
            return 1;
        }

        public override int SumEfficency()
        {
            return this.Efficency;
        }
    }
}