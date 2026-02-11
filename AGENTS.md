# Project: TeamInsight (Working Title)

## 1. Purpose

Internal RAG-based knowledge assistant for the team.

The system provides answers to user questions based on the corporate knowledge base (Vitrek).
Access is provided via Telegram bot.

This is NOT an autonomous agent.
This is NOT a tool-calling system.
This is NOT multi-tenant SaaS.

It is a simple, reliable RAG service.

---

## 2. High-Level Architecture

Components:

1. Ingestion Service (console / worker)
2. Vector Database (PostgreSQL + pgvector)
3. RAG API (.NET Web API)
4. Telegram Bot (thin client)

Data Flow:

Vitrek → Ingestion → Vector DB → RAG API → Telegram Bot → User

---

## 3. Architectural Principles

- Keep components isolated.
- No business logic inside Telegram bot.
- No orchestration tools (n8n, Zapier, etc.).
- No overengineering.
- Clean, testable services.
- All LLM interactions are inside RAG API only.
- Ingestion is idempotent.

---

## 4. Non-Goals

- No UI
- No multi-tenancy
- No role-based access control (initial version)
- No agent tool execution
- No memory between conversations
- No auto-learning from chats

---

## 5. Ingestion Service

Responsibilities:

- Pull documents from Vitrek
- Normalize content (strip HTML, etc.)
- Chunk documents (500–800 tokens)
- Generate embeddings
- Upsert into vector database

Constraints:

- Must be re-runnable safely
- Must log processing errors
- Must support partial re-indexing

---

## 6. Vector Database Schema

Table: knowledge_chunks

Columns:

- id (uuid)
- source (string)
- source_id (string)
- title (string)
- chunk_text (text)
- embedding (vector)
- metadata (jsonb)
- updated_at (timestamp)

Index:

- ivfflat or hnsw on embedding

---

## 7. RAG API

Endpoint:

POST /ask

Request:
{
"question": "string"
}

Flow:

1. Generate embedding for question
2. Retrieve top-K similar chunks
3. Assemble context
4. Build prompt
5. Call LLM
6. Return structured response

Response:
{
"answer": "string",
"sources": [
{
"title": "string",
"source_id": "string"
}
]
}

Constraints:

- Limit context size
- Limit token usage
- Fail gracefully
- Log latency

---

## 8. Prompt Design Rules

- Answer ONLY based on provided context
- If answer is not found, say so explicitly
- Prefer concise answers
- Cite sources in structured form
- No hallucinations

---

## 9. Telegram Bot

Responsibilities:

- Receive message
- Call RAG API
- Return answer
- Enforce whitelist

No business logic here.

---

## 10. Logging and Observability

Minimum requirements:

- Question text
- Latency
- Retrieved chunk count
- LLM token usage (if available)
- Errors

---

## 11. Future Extensions (Not Now)

- Access control
- Multiple knowledge sources
- Scheduled re-indexing
- Web UI
- Feedback loop
- Caching layer

These are NOT part of v1.

---

## 12. Quality Bar

The system must:

- Return deterministic results for identical inputs
- Avoid hallucination
- Be easy to deploy with docker-compose
- Be understandable by another backend engineer
