﻿using System;

namespace Shaykhullin.Injection.App
{
  internal class AppTransientCreationalBehaviour<TRegister> : ICreationalBehaviour
  {
    public IMetaInfo MetaInfo { get; }
    private readonly Func<TRegister> returns;

    public AppTransientCreationalBehaviour(Func<TRegister> returns)
    {
      MetaInfo = new AppMetaInfo<TRegister>();
      this.returns = returns;
    }

    public TResolve Create<TResolve>(params object[] args)
    {
      return (TResolve)(returns != null && args?.Length == 0
        ? returns()
        : (object)Utils.CreateInstance<TRegister>(args));
    }
  }
}