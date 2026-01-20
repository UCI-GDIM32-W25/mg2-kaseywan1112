[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/7qg5CCgx)
# HW2
## Devlog
Yaokun Wan, He/him

In my MG2 break-down activity, I planned a simple game where the player jumps to collect coins, gains points, and the UI updates. My final implementation is very similar to my original plan. 

The player jump mechanic is implemented in the Player class using the Update() method and OnCollisionEnter2D() to check if the player is grounded. This ensures that the player cannot jump while in the air, which matches my original plan. Coins are generated at irregular intervals in the CoinSpawn.Update() method using Random.Range() and Instantiate(), so the game can continue infinitely and the timing of coins is not perfectly regular. This connects directly to the “create coin” and “Coin” parts of my break-down diagram.

When the player hits a coin, OnTriggerEnter2D() detects the collision, destroys the coin, and calls Gamecontroller.AddScore(1) to increase the score. The UI text is then updated in Gamecontroller.UpdateScoreUI() using a TMP_Text object on the Canvas. This follows my original design where collision detection, points, and UI display are connected, and it allows the player to see their score update in real time.

Overall, my code follows my original design closely, so no major changes were needed during implementation.


## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - rabbit and item sprites
- [Pixel Penguin 32x32 Asset pack](https://legends-games.itch.io/pixel-penguin-32x32-asset-pack) - penguin sprites
- [Coins 2D](https://artist2d3d.itch.io/2d) - coin sprites
