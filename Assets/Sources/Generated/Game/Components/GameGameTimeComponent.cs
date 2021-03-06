//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameContext {

    public GameEntity gameTimeEntity { get { return GetGroup(GameMatcher.GameTime).GetSingleEntity(); } }
    public GameTimeComponent gameTime { get { return gameTimeEntity.gameTime; } }
    public bool hasGameTime { get { return gameTimeEntity != null; } }

    public GameEntity SetGameTime(long newTick) {
        if (hasGameTime) {
            throw new Entitas.EntitasException("Could not set GameTime!\n" + this + " already has an entity with GameTimeComponent!",
                "You should check if the context already has a gameTimeEntity before setting it or use context.ReplaceGameTime().");
        }
        var entity = CreateEntity();
        entity.AddGameTime(newTick);
        return entity;
    }

    public void ReplaceGameTime(long newTick) {
        var entity = gameTimeEntity;
        if (entity == null) {
            entity = SetGameTime(newTick);
        } else {
            entity.ReplaceGameTime(newTick);
        }
    }

    public void RemoveGameTime() {
        gameTimeEntity.Destroy();
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public GameTimeComponent gameTime { get { return (GameTimeComponent)GetComponent(GameComponentsLookup.GameTime); } }
    public bool hasGameTime { get { return HasComponent(GameComponentsLookup.GameTime); } }

    public void AddGameTime(long newTick) {
        var index = GameComponentsLookup.GameTime;
        var component = CreateComponent<GameTimeComponent>(index);
        component.Tick = newTick;
        AddComponent(index, component);
    }

    public void ReplaceGameTime(long newTick) {
        var index = GameComponentsLookup.GameTime;
        var component = CreateComponent<GameTimeComponent>(index);
        component.Tick = newTick;
        ReplaceComponent(index, component);
    }

    public void RemoveGameTime() {
        RemoveComponent(GameComponentsLookup.GameTime);
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

    static Entitas.IMatcher<GameEntity> _matcherGameTime;

    public static Entitas.IMatcher<GameEntity> GameTime {
        get {
            if (_matcherGameTime == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.GameTime);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherGameTime = matcher;
            }

            return _matcherGameTime;
        }
    }
}
