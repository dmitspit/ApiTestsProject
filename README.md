## Solution Overview
This is a .Net automated test project for Api testing.
This solution consists of several libraries and projects designed to simplify API service interactions, test data generation, and automated API testing. Below is a breakdown of the solution structure and its components:

### Tech Stack
.NET: Core technology for building libraries and applications.
RestSharp: Simplifies HTTP requests and API communication.
FluentAssertions: Enables intuitive and expressive assertions in tests.

### Solution Structure

#### 1. BaseApiClient
A foundational library for creating and managing API clients. It provides:

A reusable base class for building API services.
Support for configuring settings like encoding, content type, timeout, and optional proxy.

#### 2. FakeTestData
A utility library for generating fake test data to support testing.

#### 3. HarryPotterApiService
An API service library specifically designed for interacting with the Harry Potter API. 

#### 4. HarryPotterApiTests
Automated test framework for API tests. This project leverages FluentAssertions for clean and readable test assertions.
