﻿using UnityEngine;

public class GrowingInfoPanelView : MonoBehaviour, ISelectedEntityChangedListener {

    [SerializeField]
    private UIText nameText;
    [SerializeField]
    private UIText descriptionText;
    [SerializeField]
    private UIText producingText;
    [SerializeField]
    private UIText growingText;

    UIEntity e;

    private void OnEnable()
    {
        e = Contexts.sharedInstance.uI.CreateEntity();
        e.AddSelectedEntityChanged(this);
    }

    private void OnDisable()
    {
        if (e.isEnabled && e.hasSelectedEntityChanged)
            e.Destroy();
    }

    public void Display(GameEntity entity)
    {
        if(entity!=null && entity.hasFruit)
        {
            if(entity.hasGrowing)
            {
                producingText.content = string.Format("{0}%", (1f * entity.growing.Elapsed) / (1f * entity.fruit.FruitData.GrowthDuration));
            }

            if (entity.hasProducing)
            {
                producingText.content = string.Format("{0}%", (1f * entity.producing.Elapsed) / (1f * entity.fruit.FruitData.Frequency));
            }
        }
    }

    public void SelectedEntityChanged(GameEntity entity)
    {
        if(entity != null)
        {
            if (entity.hasFruit)
            {
                nameText.content = entity.fruit.FruitData.Name;
                descriptionText.content = entity.fruit.FruitData.Description;

                nameText.Apply();
                descriptionText.Apply();
            }

            if (entity.hasVegetable)
            {
                nameText.content = entity.vegetable.VegetableData.Name;
                descriptionText.content = entity.vegetable.VegetableData.Description;

                nameText.Apply();
                descriptionText.Apply();
            }
        }
    }
}
