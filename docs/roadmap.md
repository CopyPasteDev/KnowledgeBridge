
🧱 1. Foundation

-[x] Создать .NET 10 solution
-[x] Проекты: Api, Ingestion, TelegramBot, Infrastructure, Domain
-[x] Настроить DI и логирование
-[x] Добавить базовые интерфейсы

🗄 2. Vector Database

2.1 Контракты и решения

-[x] Зафиксировать семантику `upsert` для `source_documents` и `knowledge_chunks`
-[x] Зафиксировать контракт векторного поиска
-[ ] Выбрать способ доступа к PostgreSQL из кода

2.2 Локальный запуск БД

-[ ] Поднять PostgreSQL + `pgvector`
-[ ] Подготовить локальный bootstrap БД

2.3 Схема БД

-[ ] Создать таблицу `source_documents`
-[ ] Создать таблицу `knowledge_chunks`
-[ ] Добавить индексы и ограничения

2.4 Запись данных

-[ ] Реализовать `UpsertDocument`
-[ ] Обновлять только `updated_at` при совпавшем checksum
-[ ] Полностью заменять чанки при изменившемся checksum
-[ ] Выполнять запись в одной транзакции

2.5 Векторный поиск

-[ ] Реализовать поиск по cosine distance
-[ ] Использовать оператор `<=>` и индекс `vector_cosine_ops`
-[ ] Возвращать `ChunkSearchResult` с чанком, документом и `Score`
-[ ] Использовать `limit = 5` по умолчанию

2.6 Проверка

-[ ] Добавить тестовый каркас для 2-го этапа
-[ ] Покрыть `upsert` и поиск тестами

🔎 3. YouTrack Ingestion

-[ ] Реализовать клиент YouTrack API
-[ ] Фильтр: Resolved issues (v1)
-[ ] Нормализация текста (summary + description + comments)
-[ ] Chunking (500–800 токенов)
-[ ] Генерация embeddings
-[ ] Upsert source_documents и knowledge_chunks в vector DB

🧠 4. RAG API

-[ ] Реализовать IRagService
-[ ] Embedding вопроса
-[ ] Получить наиболее близкие чанки
-[ ] Сбор контекста
-[ ] Prompt + вызов LLM
-[ ] Endpoint POST /ask

🤖 5. Telegram Bot

-[ ] Создать бота
-[ ] Интеграция с /ask
-[ ] Ограничение доступа (whitelist)

📊 6. Stabilization

-[ ] Логирование запросов и latency
-[ ] Улучшить prompt
-[ ] Проверка на реальных вопросах

🚀 7. Deployment

-[ ] Dockerize сервисы
-[ ] docker-compose
-[ ] Развернуть на сервере
