using System.Collections.Generic;

namespace FirstRestProject.Data.Converter.Contract
{
    public interface IParser<O, D> //Origem e destino
    {
        D Parse(O origin);
        List<D> Parse(List<O> origin);

    }
}
