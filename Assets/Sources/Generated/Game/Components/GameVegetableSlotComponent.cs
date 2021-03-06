//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public VegetableSlotComponent vegetableSlot { get { return (VegetableSlotComponent)GetComponent(GameComponentsLookup.VegetableSlot); } }
    public bool hasVegetableSlot { get { return HasComponent(GameComponentsLookup.VegetableSlot); } }

    public void AddVegetableSlot(int newIndex) {
        var index = GameComponentsLookup.VegetableSlot;
        var component = CreateComponent<VegetableSlotComponent>(index);
        component.Index = newIndex;
        AddComponent(index, component);
    }

    public void ReplaceVegetableSlot(int newIndex) {
        var index = GameComponentsLookup.VegetableSlot;
        var component = CreateComponent<VegetableSlotComponent>(index);
        component.Index = newIndex;
        ReplaceComponent(index, component);
    }

    public void RemoveVegetableSlot() {
        RemoveComponent(GameComponentsLookup.VegetableSlot);
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

    static Entitas.IMatcher<GameEntity> _matcherVegetableSlot;

    public static Entitas.IMatcher<GameEntity> VegetableSlot {
        get {
            if (_matcherVegetableSlot == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.VegetableSlot);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherVegetableSlot = matcher;
            }

            return _matcherVegetableSlot;
        }
    }
}
