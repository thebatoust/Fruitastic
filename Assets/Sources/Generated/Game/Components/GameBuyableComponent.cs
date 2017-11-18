//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public BuyableComponent buyable { get { return (BuyableComponent)GetComponent(GameComponentsLookup.Buyable); } }
    public bool hasBuyable { get { return HasComponent(GameComponentsLookup.Buyable); } }

    public void AddBuyable(long newPrice) {
        var index = GameComponentsLookup.Buyable;
        var component = CreateComponent<BuyableComponent>(index);
        component.Price = newPrice;
        AddComponent(index, component);
    }

    public void ReplaceBuyable(long newPrice) {
        var index = GameComponentsLookup.Buyable;
        var component = CreateComponent<BuyableComponent>(index);
        component.Price = newPrice;
        ReplaceComponent(index, component);
    }

    public void RemoveBuyable() {
        RemoveComponent(GameComponentsLookup.Buyable);
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

    static Entitas.IMatcher<GameEntity> _matcherBuyable;

    public static Entitas.IMatcher<GameEntity> Buyable {
        get {
            if (_matcherBuyable == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Buyable);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherBuyable = matcher;
            }

            return _matcherBuyable;
        }
    }
}
