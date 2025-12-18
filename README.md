# FinalProjectInterfaces

## Autores

Jaime Martín González\
Hugo González Pérez\
Óscar García González

## Cuestiones importantes para el uso

Para el desarrollo del videojuego se ha definido un mapeo de entrada basado en un mando de PlayStation 4, por las siguientes razones:

Permite un control del desplazamiento del personaje más intuitivo y preciso mediante el uso del joystick analógico.

El sistema de disparo se ha asignado al gatillo derecho (R2), alineándose con los estándares habituales en videojuegos de acción.

Debido a este esquema de control, se recomienda el uso de un gamepad con características similares al mando de PlayStation 4 en caso de ejecutar el juego en dispositivos móviles Android o iOS.

No obstante, el proyecto también contempla la entrada mediante teclado y ratón, permitiendo su ejecución y jugabilidad completa en Windows sin necesidad de un mando compatible.

En cuanto a la interfaz, se ha optado por un sistema de selección basado en Raycasting, diseñado para ofrecer una experiencia de usuario coherente y multiplataforma. Este enfoque garantiza una interacción intuitiva tanto en Windows, Android e iOS, como en entornos de realidad virtual o ejecuciones en escritorio.

Mediante este sistema, el impacto de un proyectil sobre elementos interactivos permite diferenciar entre un disparo convencional y una acción de selección, facilitando la navegación por menús y opciones sin necesidad de interfaces adicionales

Para volver al menú principal durante la ejecución del juego, se ha habilitado la tecla `.` (punto) en el teclado o el botón Options en el mando. Esta funcionalidad permite una salida rápida y accesible al menú sin interrumpir el flujo de la experiencia de juego.


## Hitos de programación alcanzados y relación con los contenidos impartidos


Para la implementación del comportamiento de persecución de los enemigos (fantasmas), se han aplicado conceptos vistos en la asignatura, haciendo uso de métodos propios de Unity como `Vector3.MoveTowards` para el desplazamiento y ``Transform.LookAt`` para la orientación hacia el jugador.


Se ha implementado un sistema de eventos para la gestión de la eliminación de enemigos. Cuando un proyectil impacta sobre un enemigo, se lanza un evento que es capturado por el HUD, permitiendo actualizar en tiempo real el contador de enemigos eliminados en la escena.


Se emplea la generación de vectores aleatorios para controlar los saltos y desplazamientos de los enemigos en el escenario de montaña, aportando variabilidad y comportamiento no determinista.


Se ha trabajado con los ángulos de la cámara y los sistemas de referencia relativos al personaje, con el objetivo de prevenir errores visuales y comportamientos inesperados durante la ejecución.


Se utilizan distintos tipos de iluminación (Spot Light, Point Light, Directional Light y Area Light) para ambientar las escenas, así como la modificación dinámica de materiales en función del contexto y el momento del juego.


Se ha desarrollado un script específico para la actualización dinámica del texto contenido en un Canvas, utilizado como panel explicativo dentro del tutorial del juego.


Se emplean múltiples Canvas para mostrar información relevante al jugador, como el número de balas disponibles, enemigos restantes y otros datos informativos relacionados con la aplicación.

## Aspectos que destacarías en la aplicación.

Nuestro videojuego se caracteriza por ofrecer una experiencia inmersiva e intuitiva, centrada en la acción directa y en una amplia variedad de desafíos que mantienen al jugador constantemente involucrado.

Uno de los elementos más destacados del diseño es la diversidad de enemigos, lo que obliga al jugador a adaptar de forma continua su estrategia. Se incluyen enemigos estáticos, que ponen a prueba la precisión del disparo; enemigos con comportamientos de salto, que añaden dinamismo y complejidad al combate; y enemigos que persiguen activamente al jugador, incrementando la tensión y el ritmo de la experiencia de juego.

El sistema de control ha sido diseñado para funcionar de manera completa y óptima con mandos y gamepads, garantizando una interacción natural y precisa que refuerza la sensación de presencia dentro del entorno virtual. El disparo se ejecuta de forma fluida, manteniendo siempre una lectura clara y observable, especialmente teniendo en cuenta su visualización en la pantalla de dispositivos móviles.

Otro aspecto relevante es el selector de niveles, que permite al jugador elegir libremente el escenario a jugar, favoreciendo tanto sesiones rápidas como una progresión más estructurada dentro del videojuego.

Asimismo, el proyecto incorpora un tutorial inicial, orientado a familiarizar al usuario con las mecánicas básicas, los controles en realidad virtual y los distintos tipos de enemigos. Este enfoque facilita la accesibilidad incluso para jugadores sin experiencia previa en entornos de realidad virtual.

Por último, la variedad de escenarios y el diseño visual contribuyen de manera significativa a una experiencia intensa y envolvente, evitando la monotonía y logrando que el jugador se sienta plenamente integrado en un auténtico campo de batalla en realidad virtual.

## Especificar qué sensores se han incluido sensores de los que se han trabajado en interfaces multimodales.

Se ha implementado el giroscopio del dispositivo para controlar la orientación del personaje, permitiendo una rotación precisa y coherente con los movimientos del usuario.

Asimismo, se utilizan el acelerómetro y los datos de altitud del dispositivo para desarrollar una mecánica de salto basada en el movimiento físico del jugador. De este modo, al detectar un salto en el mundo real, el personaje ejecuta la acción correspondiente dentro del videojuego, reforzando la inmersión y la interacción natural con el entorno virtual.

## Gif animado de ejecución

**Mundo Principal**

_Nota:_ a diferencia de otros mundos (escenas) en esta se emplea el siguiente script [`InteractiveFrame.cs`](img/InteractiveFrame.cs) encargado de gestionar los marcos interactivos de selección de mundos. Al disparar sobre dichos marcos, se activa el teletransporte hacia el mundo seleccionado, facilitando una navegación intuitiva entre escenas.

---

**Mundo Tutorial**

_Nota:_ a diferencia de otros mundos (escenas) en esta se emplea el siguiente script [`RandomTargetWithRandomLight.cs`](img/RandomTargetWithRandomLight.cs) el cual permite que los objetivos aparezcan de forma aleatoria. Este diseño tiene como objetivo que el usuario se familiarice progresivamente con la interfaz y practique los controles básicos del videojuego. Adicionalmente, cada objetivo se ilumina con un color aleatorio para mejorar su visibilidad y facilitar su detección.

Cabe destacar el uso de iluminación tipo spotlight, la cual se activa y desactiva dinámicamente en función del objetivo activo, reforzando la atención del jugador sobre el elemento a eliminar.

---

**Mundo Montañas**

_Nota:_ a diferencia de otros mundos (escenas) en esta se emplea el siguiente script [`BouncingEnemies`](img/BouncingEnemies.cs) que permite que los enemigos realicen saltos verticales. En combinación con la incorporación de un Rigidbody con colisión en forma de cápsula, se consigue una interacción realista con el sistema de físicas del motor, aportando dinamismo a los objetivos.

---

**Mundo Castillo**

Este mundo ha sido diseñado a partir de prefabs obtenidos de la Asset Store de Unity, sobre los cuales se han realizado diversas modificaciones para adaptarlos a las necesidades del proyecto. En esta escena se han probado e integrado muchas de las mecánicas que posteriormente se han aplicado al resto de los mundos, funcionando como un entorno clave de validación y experimentación.

---

**Mundo Fantasma**

Nota: a diferencia de otras escenas en esta se emplea el siguiente script [`FollowPlayer`](img/FollowPlayer.cs) cuyo propósito es hacer que los enemigos se desplacen activamente hacia la posición del jugador, incrementando la presión y la sensación de amenaza durante la partida.


Para hacer posible la ejecución del videojuego se han realizado la siguiente lista de scripts:

| Archivo                                             | Descripción                            |
|----------------------------------------------------|--------------------------------------|
| [AmmoPickup.cs](src/AmmoPickup.cs)                  | Script para la recogida de munición. |
| [BouncingEnemies.cs](src/BouncingEnemies.cs)        | Controla enemigos que rebotan.       |
| [Bullet.cs](src/Bullet.cs)                           | Maneja el comportamiento de las balas.|
| [Cylinder.cs](src/Cylinder.cs)                       | Representa un cilindro en el juego.  |
| [Enemy.cs](src/Enemy.cs)                             | Lógica general de enemigos.           |
| [FollowPlayer.cs](src/FollowPlayer.cs)               | Enemigos que siguen al jugador.       |
| [GameManager.cs](src/GameManager.cs)                 | Controlador principal del juego.      |
| [Gun.cs](src/Gun.cs)                                 | Manejo del arma del jugador.          |
| [InfoOfControllersTimer.cs](src/InfoOfControllersTimer.cs) | Temporizador para controladores.      |
| [InteractiveFrame.cs](src/InteractiveFrame.cs)       | Gestión de marcos interactivos.       |
| [IntroCameraMove.cs](src/IntroCameraMove.cs)         | Movimiento inicial de la cámara.      |
| [MissionText.cs](src/MissionText.cs)                 | Texto de misiones en pantalla.        |
| [PistolPlay.cs](src/PistolPlay.cs)                   | Control del disparo de pistola.       |
| [PlayerControls.cs](src/PlayerControls.cs)           | Controles generales del jugador.      |
| [PlayerInputHandler.cs](src/PlayerInputHandler.cs)   | Manejo de entradas del jugador.       |
| [PlayerMovement.cs](src/PlayerMovement.cs)           | Movimiento del jugador.                |
| [RandomTargetWithRandomLight.cs](src/RandomTargetWithRandomLight.cs) | Objetivo y luces aleatorias.       |


## Acta de los acuerdos del grupo respecto al trabajo en equipo: reparto de tareas, tareas desarrolladas individualmente, tareas desarrolladas en grupo, etc.

| **Aspecto**              | **Descripción**                                                                                                                                                                                                                   |
| ------------------------ | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| **Criterio de reparto**  | El reparto de tareas se ha organizado de forma equitativa, asignando a cada integrante del equipo la responsabilidad principal del desarrollo de un nivel de juego.                                                               |
| **Responsable: Jaime**   | Desarrollo del **menú principal**, el **tutorial** y el **primer mundo**, correspondiente al escenario de la **montaña**.                                                                                                         |
| **Responsable: Hugo**    | Desarrollo completo del **nivel del castillo**.                                                                                                                                                                                   |
| **Responsable: Óscar**   | Desarrollo completo del **nivel del cementerio**.                                                                                                                                                                                 |
| **Mecánicas de juego**   | Cada integrante ha implementado las **mecánicas específicas** asociadas a su respectivo mapa.                                                                                                                                     |
| **Trabajo colaborativo** | El resto del desarrollo se ha realizado de manera **conjunta**, alternando y compartiendo tareas. Todos los miembros han participado en la mejora de mapas, mecánicas y en la elaboración y revisión del **README** del proyecto. |


![alt text](./img/IMG_0133.png)

## Check-list de recomendaciones de diseño de aplicaciones de RV indicando: se contempla, no se contempla, no aplica.

| Recomendación                                                                 | Estado          |
| ----------------------------------------------------------------------------- | --------------- |
| Uso de movimientos suaves y continuos para evitar mareos                      | Se contempla    |
| Evitar aceleraciones bruscas y cambios repentinos de cámara                   | Se contempla    |
| Orientación del jugador basada en movimientos naturales (giroscopio / cabeza) | Se contempla    |
| Interacción intuitiva mediante mandos o controladores físicos                 | Se contempla    |
| Compatibilidad con gamepads estándar                                          | Se contempla    |
| Interfaz de usuario integrada en el entorno 3D                                | Se contempla    |
| Uso de Raycasting para la selección de opciones                               | Se contempla    |
| Tamaño y legibilidad adecuados de textos en entornos VR                       | Se contempla    |
| Feedback visual claro ante acciones del usuario                               | No se contempla |
| Feedback sonoro para reforzar acciones e interacciones                        | Se contempla    |
| Tutorial inicial para familiarizar al usuario con la experiencia VR           | Se contempla    |
| Posibilidad de jugar en sesiones cortas                                       | Se contempla    |
| Evitar sobrecarga visual en escenas                                           | Se contempla    |
| Uso de iluminación adecuada para guiar al jugador                             | Se contempla    |
| Optimización del rendimiento para mantener una tasa de frames estable         | No se contempla |
| Sistema de locomoción alternativo (teletransporte)                            | No se contempla |
| Opciones avanzadas de accesibilidad (subtítulos, ajustes de confort)          | No se contempla |
| Soporte multijugador                                                          | No aplica       |
| Interacción mediante seguimiento de manos (*hand tracking*)                   | No se contempla |
| Experiencia sentada y de pie                                                  | No aplica.      |