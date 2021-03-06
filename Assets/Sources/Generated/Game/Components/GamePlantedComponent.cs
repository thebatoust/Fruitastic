//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public PlantedComponent planted { get { return (PlantedComponent)GetComponent(GameComponentsLookup.Planted); } }
    public bool hasPlanted { get { return HasComponent(GameComponentsLookup.Planted); } }

    public void AddPlanted(int newSlotIndex) {
        var index = GameComponentsLookup.Planted;
        var component = CreateComponent<PlantedComponent>(index);
        component.SlotIndex = newSlotIndex;
        AddComponent(index, component);
    }

    public void ReplacePlanted(int newSlotIndex) {
        var index = GameComponentsLookup.Planted;
        var component = CreateComponent<PlantedComponent>(index);
        component.SlotIndex = newSlotIndex;
        ReplaceComponent(index, component);
    }

    public void RemovePlanted() {
        RemoveComponent(GameComponentsLookup.Planted);
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

    static Entitas.IMatcher<GameEntity> _matcherPlanted;

    public static Entitas.IMatcher<GameEntity> Planted {
        get {
            if (_matcherPlanted == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Planted);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherPlanted = matcher;
            }

            return _matcherPlanted;
        }
    }
}
