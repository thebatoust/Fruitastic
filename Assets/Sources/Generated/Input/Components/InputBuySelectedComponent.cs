//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputEntity {

    static readonly BuySelectedComponent buySelectedComponent = new BuySelectedComponent();

    public bool isBuySelected {
        get { return HasComponent(InputComponentsLookup.BuySelected); }
        set {
            if (value != isBuySelected) {
                var index = InputComponentsLookup.BuySelected;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : buySelectedComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
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

    static Entitas.IMatcher<InputEntity> _matcherBuySelected;

    public static Entitas.IMatcher<InputEntity> BuySelected {
        get {
            if (_matcherBuySelected == null) {
                var matcher = (Entitas.Matcher<InputEntity>)Entitas.Matcher<InputEntity>.AllOf(InputComponentsLookup.BuySelected);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherBuySelected = matcher;
            }

            return _matcherBuySelected;
        }
    }
}
