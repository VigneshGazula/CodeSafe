-- Manual SQL migration to make FilePath column nullable
-- This fixes the "null value in column FilePath violates not-null constraint" error

-- Make FilePath column nullable in NoteFiles table
ALTER TABLE "NoteFiles" 
ALTER COLUMN "FilePath" DROP NOT NULL;
