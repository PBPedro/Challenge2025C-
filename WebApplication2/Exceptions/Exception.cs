using System;

namespace ChallengeC_.Exceptions
{
    public class MarcaObrigatoriaException : Exception
    {
        public MarcaObrigatoriaException()
            : base("A marca da moto é obrigatória.") { }
    }

    public class MarcaComTamanhoInvalidoException : Exception
    {
        public MarcaComTamanhoInvalidoException(int tamanhoMaximo)
            : base($"A marca da moto não pode ultrapassar {tamanhoMaximo} caracteres.") { }
    }

    public class ModeloObrigatorioException : Exception
    {
        public ModeloObrigatorioException()
            : base("O modelo da moto é obrigatório.") { }
    }

    public class PlacaObrigatoriaException : Exception
    {
        public PlacaObrigatoriaException()
            : base("A placa da moto é obrigatória.") { }
    }

    public class EstadoObrigatorioException : Exception
    {
        public EstadoObrigatorioException()
            : base("O estado da moto é obrigatório.") { }
    }

    public class LocalObrigatorioException : Exception
    {
        public LocalObrigatorioException()
            : base("O local da moto é obrigatório.") { }
    }
}
