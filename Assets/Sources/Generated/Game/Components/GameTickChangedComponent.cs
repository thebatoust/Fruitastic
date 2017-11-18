//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public TickChangedComponent tickChanged { get { return (TickChangedComponent)GetComponent(GameComponentsLookup.TickChanged); } }
    public bool hasTickChanged { get { return HasComponent(GameComponentsLookup.TickChanged); } }

    public void AddTickChanged(ITickChangedListener newListener) {
        var index = GameComponentsLookup.TickChanged;
        var component = CreateComponent<TickChangedComponent>(index);
        component.Listener = newListener;
        AddComponent(index, component);
    }

    public void ReplaceTickChanged(ITickChangedListener newListener) {
        var index = GameComponentsLookup.TickChanged;
        var component = CreateComponent<TickChangedComponent>(index);
        component.Listener = newListener;
        ReplaceComponent(index, component);
    }

    public void RemoveTickChanged() {
        RemoveComponent(GameComponentsLookup.TickChanged);
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
public partial class GameEntity : ITickChanged { }

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherTickChanged;

    public static Entitas.IMatcher<GameEntity> TickChanged {
        get {
            if (_matcherTickChanged == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.TickChanged);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherTickChanged = matcher;
            }

            return _matcherTickChanged;
        }
    }
}
