//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityInterfaceGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public interface IPlayerMoneyChanged {

    PlayerMoneyChangedComponent playerMoneyChanged { get; }
    bool hasPlayerMoneyChanged { get; }

    void AddPlayerMoneyChanged(IPlayerMoneyChangedListener newListener);
    void ReplacePlayerMoneyChanged(IPlayerMoneyChangedListener newListener);
    void RemovePlayerMoneyChanged();
}
