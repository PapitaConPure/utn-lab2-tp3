namespace AlquilerLib {
	class Casa: Propiedad, IImprimible {
		private int camasDisponibles;
		public int CamasDisponibles{get { return camasDisponibles; }set { camasDisponibles = value; }}
		public Casa(int número,string dirección,double precioBase):base(número,dirección,precioBase)
		{

		}
		public  double PrecioPorDía()
		{
			return 0;
		}
        public override string Imprimir()
        {
			return "uwu";
        }
    }
}
