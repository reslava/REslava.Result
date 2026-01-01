# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.1.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

Follows [Conventional Commits](https://www.conventionalcommits.org/en/v1.0.0/)

## [Unreleased]

## [0.0.7] - 2026-01-01

### Added

#### Core Functionality
- **Result Pattern Implementation**: Complete implementation of Result pattern for functional error handling
  - `Result` class for operations without return values
  - `Result<TValue>` generic class for operations with return values
- **Factory Methods**: Static factory methods for creating Result instances
  - `Result.Ok()` and `Result.Ok(string message)` for success scenarios
  - `Result.Fail(string)`, `Result.Fail(Error)`, `Result.Fail(IEnumerable<string>)`, `Result.Fail(IEnumerable<Error>)` for failure scenarios
  - Equivalent factory methods for `Result<TValue>`

#### Fluent API
- **Method Chaining**: Fluent interface with method chaining support
  - `WithSuccess(string)` and `WithSuccess(Success)` methods
  - `WithError(string)` and `WithError(Error)` methods
  - `WithSuccesses(IEnumerable<Success>)` and `WithErrors(IEnumerable<Error>)` methods
  - `WithValue(TValue)` for setting values on generic results
  - `WithMessage(string)` for updating reason messages
  - `WithTags(string, object)` and `WithTags(Dictionary)` for metadata

#### Reason System
- **Base Abstractions**: 
  - `Reason` abstract base class with Message and Tags properties
  - `Reason<TReason>` abstract generic class implementing CRTP pattern for type-safe fluent APIs
- **Concrete Implementations**:
  - `Success` class for representing successful outcomes
  - `Error` class for representing failures
- **Custom Error Support**: Example custom error type (`StartDateIsAfterEndDateError`) demonstrating extensibility

#### Interfaces
- `IResult` - Base result interface with success/failure status and reason tracking
- `IResult<TValue>` - Generic result interface extending IResult with value support
- `IReason` - Base reason interface
- `ISuccess` - Success marker interface
- `IError` - Error marker interface

#### Properties and State Management
- `IsSuccess` and `IsFailed` properties for checking result status
- `Reasons` list for tracking all success and error reasons
- `Errors` and `Successes` filtered readonly lists
- `Value` property with automatic failure checking (throws on failed results)
- `ValueOrDefault` property for safe value access

#### Testing
- MSTest framework integration
- Test coverage for Result creation scenarios
- Parallel test execution support

#### Documentation
- Comprehensive README with architecture overview
- UML class diagrams (detailed and simplified versions)
- CRTP pattern explanation
- Code examples demonstrating usage
- References to related patterns and libraries

### Technical Details
- **Target Framework**: .NET 10.0
- **Nullable Reference Types**: Enabled
- **Implicit Usings**: Enabled
- **Design Patterns**: CRTP (Curiously Recurring Template Pattern), Result Pattern, Fluent Interface
- **Architecture**: SOLID principles with clear interface/implementation separation

### Notes
- 🚧 This is a pre-release version under active development
- Library inspired by FluentResults and ErrorOr
- Focus on simplicity, ease of understanding, and maintainability