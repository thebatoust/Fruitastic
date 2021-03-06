//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public GrowableComponent growable { get { return (GrowableComponent)GetComponent(GameComponentsLookup.Growable); } }
    public bool hasGrowable { get { return HasComponent(GameComponentsLookup.Growable); } }

    public void AddGrowable(long newDuration) {
        var index = GameComponentsLookup.Growable;
        var component = CreateComponent<GrowableComponent>(index);
        component.Duration = newDuration;
        AddComponent(index, component);
    }

    public void ReplaceGrowable(long newDuration) {
        var index = GameComponentsLookup.Growable;
        var component = CreateComponent<GrowableComponent>(index);
        component.Duration = newDuration;
        ReplaceComponent(index, component);
    }

    public void RemoveGrowable() {
        RemoveComponent(GameComponentsLookup.Growable);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherGrowable;

    public static Entitas.IMatcher<GameEntity> Growable {
        get {
            if (_matcherGrowable == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Growable);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherGrowable = matcher;
            }

            return _matcherGrowable;
        }
    }
}
