//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityInterfaceGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public interface IPlantedEntityChanged {

    PlantedEntityChangedComponent plantedEntityChanged { get; }
    bool hasPlantedEntityChanged { get; }

    void AddPlantedEntityChanged(IPlantedEntityChangedListener newListener);
    void ReplacePlantedEntityChanged(IPlantedEntityChangedListener newListener);
    void RemovePlantedEntityChanged();
}
