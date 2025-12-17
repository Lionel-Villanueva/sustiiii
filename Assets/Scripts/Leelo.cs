Examen Sustitutorio
Indicaciones:
 	1.- Entregar su celular al profesor.
	2.- Sentarse en los asientos indicados por su profesor.
	3.- Subir los entregables al laboratorio.
	4.- El uso de cualquier tipo de IA queda terminantemente prohibido , si se detecta el uso de IA se anula inmediatamente el examen.
Requerimientos:
	1.Crear una clase padre llamada BaseEntity con los atributos ID, Name, Description e Icon (tipo Sprite).(1p)
2. Crear tres clases derivadas de BaseEntity: Player, BaseEnemy y BaseObject.(1p)
3. Crear una interfaz llamada IDamageable con un método TakeDamage(int amount).(1p)
4. Implementar IDamageable en Player, BaseEnemy y BaseObject, donde el Player pierde vida y reinicia la escena si su vida llega a 0, el BaseEnemy se destruye si su vida llega a 0, y el BaseObject se destruye instantáneamente al recibir daño.(3p)
5. Crear un GameManager con referencia al Player, un contador de score, y referencias a los spawners; debe guardar y recuperar el score con PlayerPrefs.(2p)
6. Crear un Spawner que genere enemigos alrededor del jugador y tenga un método para eliminar a todos los enemigos generados.(3p)
7. Los BaseEnemy se moverán en dirección al player, hacer esta lógica usando lo visto en clase aplicando únicamente vectores.(2p)
8. Implementar un controlador(New Input system) top-down para el Player que permite el movimiento usando Rigidbody2D.(2p)
9. Permitir que el jugador dispare proyectiles para hacer daño a los enemigos al hacer clic, con dirección hacia la posición del mouse haciendo uso de físicas y orientando su rotación usando vectores.(3p)
10. Aumentar el score y muestralo cada vez que se elimina un enemigo y guardar el score con PlayerPrefs para mantenerlo entre sesiones.(2p)


Entregables:
	1.- La Carpeta con el ejecutable.
	2.- El archivo UnityPackage.
	3.- Subir los archivos en una carpeta en el foro asignado

