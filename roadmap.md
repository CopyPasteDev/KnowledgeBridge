
🧱 1. Foundation

-[ ] Создать .NET 8 solution
-[ ] Проекты: Api, Ingestion, TelegramBot, Infrastructure, Domain
-[ ] Настроить DI и логирование
-[ ] Добавить базовые интерфейсы

🗄 2. Vector Database

-[ ] Поднять PostgreSQL + pgvector
-[ ] Создать таблицу knowledge_chunks
-[ ] Реализовать IVectorStore (upsert + similarity search)

🔎 3. YouTrack Ingestion

-[ ] Реализовать клиент YouTrack API
-[ ] Фильтр: Resolved issues (v1)
-[ ] Нормализация текста (summary + description + comments)
-[ ] Chunking (500–800 токенов)
-[ ] Генерация embeddings
-[ ] Upsert в vector DB

🧠 4. RAG API

-[ ] Реализовать IRagService
-[ ] Embedding вопроса
-[ ] Top-K similarity search
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