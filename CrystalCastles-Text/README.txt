Coding Conventions: 

1. When naming everything is singular. The only exception is Crystal Castles, as it's a reference to
   a band I like.

   An example: 
   Creatures -> Creature 
   CreaturesAttack -> CreatureAttack (or MultipleCreatureAttack)
   
   If it doesn't make sense grammatically that's your fault. I better not see a "s" at the end of a
   word that doesn't need it.

2. Methods should only have one purpose. A good way to test if a method has multiple purposes is
   if you have to say "and" when describing it. Make it two methods. 

3. Try to keep line count under 100 this is more lax depending on reasoning. This also doesn't include
   any lines that are comments or describing code.

4. Describe each method using Unity's/C# documentation template. "///" enter should get it, if not
   look it up. Looks something like this:
   /// <summary>
   /// Gets or sets the property.
   /// </summary>
   /// <value>
   /// The property.
   /// </value>

5. Assume I'm an idiot, when documentating anything more complex than a condition checker/wrapper
   spell it out for me. Like for loops. Describe functions on how they should be used and how they
   shouldn't be used.

6. Classes/methods should be as generic as possible. One good way to test is: 
   void AttackFormula (Creature creature)
   {
        return creature.baseAttack + creature.weaponAttack;
   }
   
   Scan that code and ask what variables am I using, notice how you're only using two numbers and
   nothing else? It should be written as:

   void AttackFormula (int baseAttack, int weaponAttack)
   {
        return baseAttack + weaponAttack;
   }

7. Think of classes as creating libraries.

8. Use namespaces.

9. Follow the C# conventions.

10. If you stumble upon doing (int)Mask.Default you probably want to just make a class with a
    immutable int Default = 1. Enums should be transfered through paramaters etc.

11. At NO POINT should strings be used in a programming sense unless it's literally something that
    will be seen on the screen. If Unity forces you to use a string i.e. Input.GetAxis("Mouse X") 
    create a new class file in the correct namespace and have it as a immutable static value.

12. Rules of Polymorphing:
    1. If it needs the previous file in a domino way, i.e. xForm needs Weapon.
    2. But if it doesn't i.e. creature needs physics and raycast but which comes first physics or
       raycast? When it doesn't make sense to put either first treat them as components, or seperate
       class files if it isn't a monobehaviour.

13. Prefer easier to change over optimize code. Once the code starts glitching/getting unreadable
    and messy then optimize takes priority. Everything should be easy to delete. Example have an
    error appear if creature isn't hooked up to Sprite Renderer. *Don't* make it so Creature has on
    Start, getcomponet<SpriteRenderer> ().

14. Crystal Castles prefers the user to drag the component onto the object rather than
    GetComponet<ObjectName> at the start. I believe this is more clear for the gameobjects. Have an
    error appear with a button to equip it, if it's important for it to be dragged.
