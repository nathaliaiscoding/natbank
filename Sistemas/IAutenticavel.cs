using System;

namespace NatBank
{
    public interface IAutenticavel
    {
        bool Autenticar(string senha);
    }
}