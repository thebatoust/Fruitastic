//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputEntity {

    public PlantSelectedEntityComponent plantSelectedEntity { get { return (PlantSelectedEntityComponent)GetComponent(InputComponentsLookup.PlantSelectedEntity); } }
    public bool hasPlantSelectedEntity { get { return HasComponent(InputComponentsLookup.PlantSelectedEntity); } }

    public void AddPlantSelectedEntity(GameEntity newEntity) {
        var index = InputComponentsLookup.PlantSelectedEntity;
        var component = CreateComponent<PlantSelectedEntityComponent>(index);
        component.Entity = newEntity;
        AddComponent(index, component);
    }

    public void ReplacePlantSelectedEntity(GameEntity newEntity) {
        var index = InputComponentsLookup.PlantSelectedEntity;
        var component = CreateComponent<PlantSelectedEntityComponent>(index);
        component.Entity = newEntity;
        ReplaceComponent(index, component);
    }

    public void RemovePlantSelectedEntity() {
        RemoveComponent(InputComponentsLookup.PlantSelectedEntity);
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

    static Entitas.IMatcher<InputEntity> _matcherPlantSelectedEntity;

    public static Entitas.IMatcher<InputEntity> PlantSelectedEntity {
        get {
            if (_matcherPlantSelectedEntity == null) {
                var matcher = (Entitas.Matcher<InputEntity>)Entitas.Matcher<InputEntity>.AllOf(InputComponentsLookup.PlantSelectedEntity);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherPlantSelectedEntity = matcher;
            }

            return _matcherPlantSelectedEntity;
        }
    }
}
