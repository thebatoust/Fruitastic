//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class UIEntity {

    public PlantedEntityChangedComponent plantedEntityChanged { get { return (PlantedEntityChangedComponent)GetComponent(UIComponentsLookup.PlantedEntityChanged); } }
    public bool hasPlantedEntityChanged { get { return HasComponent(UIComponentsLookup.PlantedEntityChanged); } }

    public void AddPlantedEntityChanged(IPlantedEntityChangedListener newListener) {
        var index = UIComponentsLookup.PlantedEntityChanged;
        var component = CreateComponent<PlantedEntityChangedComponent>(index);
        component.Listener = newListener;
        AddComponent(index, component);
    }

    public void ReplacePlantedEntityChanged(IPlantedEntityChangedListener newListener) {
        var index = UIComponentsLookup.PlantedEntityChanged;
        var component = CreateComponent<PlantedEntityChangedComponent>(index);
        component.Listener = newListener;
        ReplaceComponent(index, component);
    }

    public void RemovePlantedEntityChanged() {
        RemoveComponent(UIComponentsLookup.PlantedEntityChanged);
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
public partial class UIEntity : IPlantedEntityChanged { }

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class UIMatcher {

    static Entitas.IMatcher<UIEntity> _matcherPlantedEntityChanged;

    public static Entitas.IMatcher<UIEntity> PlantedEntityChanged {
        get {
            if (_matcherPlantedEntityChanged == null) {
                var matcher = (Entitas.Matcher<UIEntity>)Entitas.Matcher<UIEntity>.AllOf(UIComponentsLookup.PlantedEntityChanged);
                matcher.componentNames = UIComponentsLookup.componentNames;
                _matcherPlantedEntityChanged = matcher;
            }

            return _matcherPlantedEntityChanged;
        }
    }
}
