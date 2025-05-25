“Hopscotch”

## Idea

VR Hopscotch** is a playful and immersive virtual reality version of the classic playground game "Hopscotch." The prototype aims to prove that traditional physical games can be successfully adapted into XR to promote physical activity, spatial awareness, and nostalgia in a fun, engaging way. It’s a great idea for XR because it encourages natural body movement (jumping and aiming) and leverages spatial tracking to enhance interaction and immersion.

![Polish_20250523_143516067.png](attachment:f5be5304-dd56-41f3-a27c-434c8e71f45c:Polish_20250523_143516067.png)

## Features

**Core features:** 

- VR locomotion system that tracks the player’s real-life steps/jumps using headset or hand movement or foot trackers. (*I’m considering using hand tracking such as moving hands upward to simulate jumping instead of requiring players to actually jump. Would that be a better approach, or should real jumping still be used? And if real jumping is preferred, what would be the recommended or safest way to implement it in VR?*)
- Interactive hopscotch grid rendered in 3D space. (*If there's enough time, Is it possible or advisable to allow users to draw or customize their own hopscotch grid?*)
- Realistic hopscotch mechanics: throw a virtual marker (stone), jump on specific tiles, avoid marked tile.
- Visual/audio feedback for actions (landing on correct/wrong tile, completing round, throwing marker).

**Stretch goals:** 

- Mixed Reality mode to project hopscotch grid on real-world surfaces. (*Is it possible to implement this on Meta Quest 2, even if the passthrough is only black and white? Also, which Unity version would you recommend for best compatibility with passthrough features? In my previous prototype, the passthrough only showed a blue screen and all VR assets were shaking—what could be the cause of that?*)
- Jump tracker (*counting jumps and converting to estimated calories burned if the real jump approach is used*).
- Design custom hopscotch patterns. (*If there's enough time for develop*)

## Tech Stack

- Meta Quest Body Tracking (for full body tracking)
