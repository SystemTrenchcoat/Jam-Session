using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundHandler
{
   //public static event Action OnExitGame; -> in Rhythm.cs

   /*Or maybe make a list containing the backgrounds 
     if more are gonna be added in the future*/ 
   [SerializeField] private Sprite dayBackground;
   [SerializeField] private Sprite nightBackground;
   private bool isDay;
   private SpriteRenderer spriteRenderer;

   
   private void Start()
   {
      Rhythm.OnExitGame += SetBackground();
   }
    private void SetBackground() 
    {
          if(isDay) 
          {
               spriteRenderer.sprite = nightBackground;
               isDay = !isDay;
          }
          else 
          {
               spriteRenderer.sprite = dayBackground;
               isDay = !isDay;
          }
    }
}