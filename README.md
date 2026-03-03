# DotNet Interview API (AI-First)

## Goal
This exercise measures two things together:
1. Your ability to build/debug C# REST APIs.
2. Your ability to use AI coding assistants effectively and safely.

## Timebox
- Hard limit: **30 minutes**
- Expected for strong AI-assisted workflow: **~15 minutes**

## Allowed Tools
AI assistant use is **expected** for this exercise.

You may use any of the following:
- Codex
- Claude
- GitHub Copilot Chat
- Equivalent AI coding assistant

Use of AI is part of the evaluation. You are expected to verify and correct AI output.

## Setup
1. Clone this repository.
2. Create a branch named `<your-first-name>-updates`.
3. Complete the required tasks below.
4. Commit your changes to your branch.

## Required Tasks
1. Make the project build successfully.
2. Implement RESTful endpoints for `Sport`:
   - List all sports
   - Get sport by ID
   - Create sport
   - Update sport by ID
   - Delete sport by ID
3. Ensure endpoint behavior is correct:
   - Use appropriate HTTP status codes.
   - Return `404` when an ID is not found.
   - Reject invalid request bodies with `400`.
   - Do not leave any method returning `null` or throwing `NotImplementedException`.
4. Add request timing for "get sport by ID" and write the result to a file.
5. Fill out `AI_USAGE.md` in this repo.

## Deliverables
Your branch should include:
1. Working code for the required API behavior.
2. `AI_USAGE.md` completed with your real workflow.
3. A short note in commit message(s) describing major fixes/decisions.

## AI Usage Expectations
You are not graded on writing all code manually.
You are graded on whether you can:
1. Ask useful questions/prompts.
2. Detect incorrect AI suggestions.
3. Verify behavior quickly.
4. Ship a correct result within time.

## Notes
- Keep changes focused on completing the required tasks.
- Optional extras (Swagger, PATCH endpoint, config cleanup) are welcome only if required tasks are already done.
