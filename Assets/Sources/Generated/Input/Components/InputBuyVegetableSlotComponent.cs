//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputEntity {

    public BuyVegetableSlotComponent buyVegetableSlot { get { return (BuyVegetableSlotComponent)GetComponent(InputComponentsLookup.BuyVegetableSlot); } }
    public bool hasBuyVegetableSlot { get { return HasComponent(InputComponentsLookup.BuyVegetableSlot); } }

    public void AddBuyVegetableSlot(int newIndex) {
        var index = InputComponentsLookup.BuyVegetableSlot;
        var component = CreateComponent<BuyVegetableSlotComponent>(index);
        component.Index = newIndex;
        AddComponent(index, component);
    }

    public void ReplaceBuyVegetableSlot(int newIndex) {
        var index = InputComponentsLookup.BuyVegetableSlot;
        var component = CreateComponent<BuyVegetableSlotComponent>(index);
        component.Index = newIndex;
        ReplaceComponent(index, component);
    }

    public void RemoveBuyVegetableSlot() {
        RemoveComponent(InputComponentsLookup.BuyVegetableSlot);
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
public sealed partial class InputMatcher {

    static Entitas.IMatcher<InputEntity> _matcherBuyVegetableSlot;

    public static Entitas.IMatcher<InputEntity> BuyVegetableSlot {
        get {
            if (_matcherBuyVegetableSlot == null) {
                var matcher = (Entitas.Matcher<InputEntity>)Entitas.Matcher<InputEntity>.AllOf(InputComponentsLookup.BuyVegetableSlot);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherBuyVegetableSlot = matcher;
            }

            return _matcherBuyVegetableSlot;
        }
    }
}
