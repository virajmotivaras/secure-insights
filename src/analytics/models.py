from dataclasses import dataclass
from datetime import datetime


@dataclass
class NoteRecord:
    note_id: str
    title: str
    content: str
    category: str
    created_by_user_id: str
    created_at_utc: datetime
    updated_at_utc: datetime


@dataclass
class UserRecord:
    user_id: str
    name: str
    email: str
    role: str
    is_active: bool


@dataclass
class AuditEventRecord:
    audit_event_id: str
    event_type: str
    entity_type: str
    entity_id: str
    triggered_by_user_id: str
    occurred_at_utc: datetime