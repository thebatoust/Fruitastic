//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public PlayerMoneyChangedComponent playerMoneyChanged { get { return (PlayerMoneyChangedComponent)GetComponent(GameComponentsLookup.PlayerMoneyChanged); } }
    public bool hasPlayerMoneyChanged { get { return HasComponent(GameComponentsLookup.PlayerMoneyChanged); } }

    public void AddPlayerMoneyChanged(IPlayerMoneyChangedListener newListener) {
        var index = GameComponentsLookup.PlayerMoneyChanged;
        var component = CreateComponent<PlayerMoneyChangedComponent>(index);
        component.Listener = newListener;
        AddComponent(index, component);
    }

    public void ReplacePlayerMoneyChanged(IPlayerMoneyChangedListener newListener) {
        var index = GameComponentsLookup.PlayerMoneyChanged;
        var component = CreateComponent<PlayerMoneyChangedComponent>(index);
        component.Listener = newListener;
        ReplaceComponent(index, component);
    }

    public void RemovePlayerMoneyChanged() {
        RemoveComponent(GameComponentsLookup.PlayerMoneyChanged);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityInterfaceGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity : IPlayerMoneyChanged { }

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherPlayerMoneyChanged;

    public static Entitas.IMatcher<GameEntity> PlayerMoneyChanged {
        get {
            if (_matcherPlayerMoneyChanged == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.PlayerMoneyChanged);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherPlayerMoneyChanged = matcher;
            }

            return _matcherPlayerMoneyChanged;
        }
    }
}
