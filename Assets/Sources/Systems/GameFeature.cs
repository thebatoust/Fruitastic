﻿using Entitas;

public class GameFeature : Feature {
    
    public GameFeature(Contexts contexts) : base("Game Systems")
    {
        Add(new StartNewGameSystem(contexts));
        Add(new IncrementGameTimeSystem(contexts));
        Add(new NotifyTickChangedListenersSystem(contexts));
        Add(new NotifyPlayerMoneyChangedSystem(contexts));
        Add(new NotifyFruitSlotChangedSystem(contexts));
        Add(new NotifyStoredEntitiesNumberChangedSystem(contexts));
        Add(new NotifySelectedEntityChangedSystem(contexts));
        Add(new NotifyPlantedFruitChangedSystem(contexts));
        Add(new NotifyGrowingEntityChangedSystem(contexts));
        Add(new NotifyProducingEntityChangedSystem(contexts));
        Add(new GrowGrowableSystem(contexts));
        Add(new ProduceFruitSystem(contexts));
    }

}
