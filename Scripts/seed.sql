-- Datos iniciales del Sistema Veterinario.
-- Ejecutar DESPUÉS de schema.sql (con la base de datos db_veterinaria ya creada).
--
-- Motivo: las citas y el historial clínico referencian un id_empleado (por ahora 1),
-- por lo que la tabla "empleado" no puede estar vacía o las altas fallarían por
-- violación de clave foránea.

-- Empleado por defecto (ADMIN) usado como autor de citas y consultas.
-- El PIN '1234' es de demostración académica; cámbielo para uso real.
INSERT INTO public.empleado (id_empleado, nombre, rol, clave_pin)
VALUES (1, 'Dr. Fernando Morales', 'ADMIN', '1234')
ON CONFLICT (id_empleado) DO NOTHING;

-- Sincronizar la secuencia de la tabla con el id insertado.
SELECT setval('public.empleado_id_empleado_seq',
              (SELECT COALESCE(MAX(id_empleado), 1) FROM public.empleado));
