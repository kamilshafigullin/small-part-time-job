import psycopg2

# Узнать в каком файле находится база данных
def get_db_placement(self):
    q = 'show data_directory;'
    cur.execute(q)
    print(cur.fetchall())

#  Узнать размер БД
def get_db_size(self):
    q = 'select pg_database_size(%s);'
    cur.execute(q, ('postgresdb', ))
    row = cur.fetchone()
    print(str(row[0]))

# Создание таблицы
def create_table(self):
    cur.execute("CREATE TABLE worker (id SERIAL PRIMARY KEY, " +
        "first_name text, age INTEGER)")
    con.commit()

# Размер таблицы
def get_table_size(self):
    q = 'select pg_size_pretty(pg_table_size(%s));'
    cur.execute(q, ('worker', ))
    row = cur.fetchone()
    print(str(row[0]))

# Очистить всё содержимое таблицы
def truncate_table(self):
    q = 'TRUNCATE worker;'
    cur.execute(q)
    con.commit()

# Поиск таблицы TOAST
def search_toast(self):
    q = 'SELECT relname, reltoastrelid FROM pg_class WHERE relname = %s;'
    cur.execute(q, ('worker', ))
    print(cur.fetchall())

# Заполнение данных случайными значениями
def insert_rand(self):
    q = (
        f"insert into worker ("
        f"id, first_name, age"
        f")"
        f"select "
        f"i,"
        f"md5(random()::text),"
        f"random()*10000+1"
        f"from generate_series(1, 100000) i;"
        )
    cur.execute(q)
    con.commit() # сохраняем изменения

# Показать таблицу TOAST
def show_toast(self):
    q = 'SELECT * FROM pg_toast.pg_toast_24591;'
    cur.execute(q)
    print(cur.fetchall())

# Узнать название таблицы TOAST
def get_toast_name():
    q = 'SELECT relname FROM pg_class WHERE oid = 24595;'
    cur.execute(q)
    print(cur.fetchall())

# Очистка данных vacuum
def vacuum(self):
    con.set_isolation_level(psycopg2.extensions.ISOLATION_LEVEL_AUTOCOMMIT)
    q = "VACUUM FULL worker"
    cur.execute(q)
    con.commit()



con = psycopg2.connect(
    database="postgresdb",
    user="postgres",
    password="1234",
    host="localhost",
    port="5432"
)

print("Database opened successfully")

#cursor
cur = con.cursor()

# Закрыть курсор
cur.close()
# Закрыть подключение
con.close()