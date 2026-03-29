# Rencher Design — Project Context
*Paste this at the start of a new conversation to restore full context.*

---

## Who You Are

**Tyler Rencher** — Spring City, Utah. 13-year professional .NET/Azure software engineer (backend, targeting full-stack roles). Married with 7 homeschooled children. You designed and built your own off-grid home on 40 acres outside Spring City for your family — 2 children were born there. The home is your primary case study and proof of expertise.

---

## The Business: Rencher Design LLC

- **Entity:** Utah LLC, formed and registered
- **Domain:** rencherdesign.com
- **Email:** tyler@rencherdesign.com (Google Workspace)
- **Phone:** 435-562-5964 (local 435 area code)
- **EIN:** Obtained
- **Location:** Spring City, Utah (North Sanpete County)
- **Tax structure:** Default single-member LLC pass-through. Evaluate S-Corp election with CPA when net profit exceeds ~$50–80K/yr.

### Brand
- **Tagline:** "Architectural design for those who value technical excellence alongside family comfort."
- **Voice:** First person "I" throughout — never "we" or "our." Warm but technically credible.
- **Primary CTA:** "Begin Your Project"
- **Colors:** Primary `#313030`, Secondary `#7c5730`, Surface `#fcf9f6`, Secondary-container `#fdcb9b`
- **Fonts:** Noto Serif (headlines), Plus Jakarta Sans (body)

### The Origin Story (use in copy)
- Childhood dream of being an architect
- Moved to Seattle for software career, family grew, house too small
- COVID → went remote → decided to go rural and off-grid
- Purchased 40 acres outside Spring City with no services (power/water/sewer)
- Designed and built the home himself — full permitting, navigated county that had never reviewed an off-grid electrical system
- Most proud of: air sealing. Floor and ceiling temps are nearly identical. Standard forced-air system, extraordinary comfort.
- Software→design parallel: defects are cheapest to fix in the design phase. "Unlike software, you can't release a new version of a house."
- Goal for clients: make most decisions upfront so they don't face them under pressure mid-build.

---

## Services (Public)

### Standard Home Drafting · ~$4,000 base (up to ~2,000 sq ft)
Straightforward permit package for conventional homes. Floor plans, elevations, site plan, basic electrical, basic plumbing/septic, standard wall sections. 1 revision round. Comprehensive requirements analysis. Transactional. $1.50 per sq ft after 2000 sqft. Pricing maps to about 1% project cost. Standard finishes. High finish level requires custom quote which is 1% of project cost.

### High-Performance Home Drafting · $8,000 base (up to ~2,000 sq ft)
Everything in Standard plus: air sealing & envelope details, detailed room by room HVAC plan with schematic (load-calculated), detailed electrical, detailed cabinet plan, 2 revision rounds, build support throughout construction. $3 per sq ft after 2000 sq ft. Pricing maps to about 2% project cost. Standard finishes. High finish level requires custom quote which is 2% of project cost.

### Off-Grid System Design · Custom quote
Add-on or standalone. Load profile analysis, solar array sizing (winter worst-case), battery/generator sizing, water system design. Time-intensive, analyzed individually. Cannot be estimated by formula.

### Plan Submittal · 1% estimated project cost
I will handle all communication with your AHJ, submit your plans, rework as needed, and deliver your building permit.

### Project Management · 5% estimated project cost + Expenses
**North Sanpete County only.** Develop raw land into a buildable lot. Engage surveyor. Engage state water commission. Standard plan set included. Engage structural engineer. Engage septic designer. Interface with county planning and zoning. Interface with county commissioners. Plan submittal to county building department. Weekly in-person site inspection visits. Written report after each visit. Similar to an architect's services.

### Private / Word-of-Mouth Only
Budget drafting at ~$1.25/sq ft finished, $0.75/sq ft unfinished. $750 minimum. Draw your plans as written, fix major code problems, limited discussion of whether the plans will work well. Revisions billed hourly. **Not listed publicly.** Keeps brand positioning intact.

### Pricing notes
- All fees include flat fee with hourly overage for revisions beyond included rounds
- Discovery fees credited to project total
- Engineer stamp not included (structural engineer reviews and stamps; Tyler produces drawings)
- Many locations don't require licensed architect or engineer for single-family residential but I recommend getting an engineer's review and stamp on the plans
- Hourly rate $100

---

## Process (6 Steps)

1. **First conversation** — Free, 30–45 min. Fit assessment.
2. **Deep discovery** — $500 Paid (credited to project). 1–3 sessions 1-2 hours each. Land, goals, rough sketch, architectural style, budget. Done by video call or in person.
3. **Proposal & engagement** — Quote + contract.
4. **Design & drawing** — CAD, defined revision rounds, additional revisions hourly.
5. **Permit package delivery** — Complete numbered drawing set, engineer-review ready.
6. **Build support** — Available throughout construction. Framer and HVAC subs are most critical to watch.

---

## Website — Completed Pages

All pages use the same design system (Tailwind CSS, Noto Serif, Plus Jakarta Sans, brand color palette). All delivered as `.html` files for Cloudflare Pages deployment.

| File | Status | Notes |
|------|--------|-------|
| `index.html` | ✅ Complete | Homepage with credibility bar, philosophy, bento grid, software differentiator section, contact form |
| `about.html` | ✅ Complete | Tyler's full story: childhood architect dream → Seattle → COVID → off-grid build → air sealing pride → software parallel |
| `services.html` | ✅ Complete | All service packages with pricing cards, sticky jump nav, FAQ section |
| `process.html` | ✅ Complete | 6-step connected timeline, free/paid labels, detailed step copy |
| `privacy.html` | ✅ Complete | First-person privacy commitment, privilege callout box, Cloudflare note |
| `case_studies.html` | ✅ Complete | My own home story with pictures and discussion of the process, air testing |
| `journal.html` | ✅ Complete | Series of pages with my thoughts on home design, how designers deliver value, value of high performance homes | 
| `entries/*.html` | ✅ Complete | Journal entries on various topics. These are all advertising. |
| `customer_portal.html` | Incomplete | Contains documents for the customer's build |

**Deployment:** Cloudflare Pages (free tier — unlimited static requests/bandwidth, 500 builds/month). Contact form needs Formspree or Calendly wired up before launch.

**File structure:**
```
/index.html
/about.html
/services.html
/process.html
/privacy.html
/case_studies.html
/journal.html
/journal/*.html
/portfolio.html
/prepare.html
```

**Nav bar:** All pages to have the same nav bar. The link order should be About Journal Services Portfolio Process Contact. Mobile should see a hamburger menu with the links. Contact should be a button with the text Begin Your Project.
---

## Letterheads — Completed

Three `.docx` letterhead templates delivered. Each has letterhead in Word header/footer so body starts clean. US Letter size.

| File | Style |
|------|-------|
| `Letterhead.dotx` | Cream background, Georgia wordmark, brown rule, dark footer bar | 

---

## Portfolio Project: RencherDesign

**Concept:** Off-grid home design lead generation platform. Client completes guided intake → calculation engine runs (solar via NREL PVWatts, thermal via Open-Meteo, water via NOAA) → interactive results dashboard → consultation booking CTA. Admin portal for lead management.

**Tech stack:**
- Frontend: Next.js (React + TypeScript)
- Backend: .NET 8 Minimal API, clean architecture, CQRS/MediatR, xUnit + FsCheck
- Azure: Container Apps, Azure SQL, Blob Storage, Azure Functions, APIM, Key Vault, App Insights, Azure AD B2C
- External APIs: NREL PVWatts, Open-Meteo, NOAA, USGS Elevation
- DevOps: Azure DevOps CI/CD, Docker, Bicep IaC

**14-week build plan (thin slices):**
- Weeks 1–2: Scaffolding + land/location slice
- Weeks 3–4: Lifestyle intake wizard
- Weeks 5–7: Calculation engine (solar, thermal, water)
- Weeks 8–9: Results dashboard + lead capture
- Weeks 10–11: Admin portal
- Weeks 12–14: Public site, hardening, portfolio writeup

---

## Pending To-Dos

- [ ] Consult CPA about S-Corp election timing
- [ ] Consult IP attorney about trademark when generating revenue (search TESS first)
- [ ] Start GridZero build (Week 1: scaffolding)

---

## Key Copy Decisions (maintain consistency)

- Always "I" not "we" — first person throughout
- "Begin Your Project" is the primary CTA everywhere
- "Connect With Me" not "Connect With Us"
- Form placeholder: "Tell me about your land, your family, and what you're dreaming of building..."
- Footer tagline: "Architectural design for those who value technical excellence alongside family comfort."
- Pull quote to use: "Unlike software, where you can release a new version, you can't release a new version of a house."
- Air sealing pride quote: "In my home, the air temperature at the floor and ceiling is nearly identical."
- Off-grid credibility line: "I know what the numbers need to look like in January — not just on a sunny day in July."
