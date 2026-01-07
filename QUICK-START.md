# Quick Start Guide - REslava.Result

Welcome! This guide explains how to use the commit automation in your daily workflow.

## 📋 Table of Contents

- [Daily Workflow](#-daily-workflow)
- [Making Commits](#-making-commits)
- [Commit Types Reference](#-commit-types-reference)
- [Working with Branches](#-working-with-branches)
- [Creating Releases](#-creating-releases)
- [Common Scenarios](#-common-scenarios)
- [Troubleshooting](#-troubleshooting)
- [Tips & Best Practices](#-tips--best-practices)

---

## 🔄 Daily Workflow

### Standard Development Cycle

```bash
# 1. Pull latest changes
git pull

# 2. Create a feature branch (optional but recommended)
git checkout -b feature/my-feature

# 3. Make your code changes
# ... edit files ...

# 4. Stage your changes
git add .

# 5. Commit using automation (IMPORTANT!)
npm run commit

# 6. Push your changes
git push
