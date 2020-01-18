namespace PCAssembler
{
    internal class RAM : Component
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