﻿namespace Shaykhullin.Injection
{
  public interface IServiceEntity<TRegister> : ICreationalSelector<TRegister, TRegister>
  {
    ICreationalSelector<TRegister, TResolve> As<TResolve>();
    IServiceEntity<TRegister> Returns(TRegister returns);
    IServiceEntity<TRegister> Named(string named);
  }
}