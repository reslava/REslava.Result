```mermaid
classDiagram
    class IReason {
        <<interface>>        
    }
    
    class ISuccess {
        <<interface>>
    }
    
    class IError {
        <<interface>>
    }
    
    class IResult {
        <<interface>>        
        +List~IReason~ Reasons        
    }
    
    class IResult_TValue {
        <<interface>>
        +TValue? Value        
    }
    
    class Reason {
        <<abstract>>        
    }
    
    class Reason_TReason {
        <<abstract>>        
    }
    
    class Success 
    
    class Error 
    
    class Result {
        +List~IReason~ Reasons        
    }
    
    class Result_TValue {        
        +TValue? Value        
    }
    
    IReason <|.. ISuccess : extends
    IReason <|.. IError : extends
    IResult <|-- IResult_TValue : extends
    
    IReason <|.. Reason : implements
    Reason <|-- Reason_TReason : extends
    Reason_TReason <|-- Success : extends~Success~
    Reason_TReason <|-- Error : extends~Error~
    Success ..|> ISuccess : implements
    Error ..|> IError : implements
    
    IResult <|.. Result : implements
    Result <|-- Result_TValue : extends
    Result_TValue ..|> IResult_TValue : implements
    
    Result o-- IReason : contains
    Result_TValue o-- TValue : contains