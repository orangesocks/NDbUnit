﻿/*
 *
 * NDbUnit
 * Copyright (C)2005 - 2011
 * http://code.google.com/p/ndbunit
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */

using NDbUnit.Core.SqlServerCe;
using NUnit.Framework;

namespace NDbUnit.Test.SqlServerCe
{
    [Category(TestCategories.SqlServerCeTests)]
    public class SqlCeDbUnitIntegrationTest : IntegationTestBase
    {
        protected override NDbUnit.Core.INDbUnitTest GetNDbUnitTest()
        {
            return new SqlCeDbUnitTest(DbConnection.SqlCeConnectionString);
        }

        protected override string GetXmlFilename()
        {
            return XmlTestFiles.SqlServerCe.XmlFile;
        }

        protected override string GetXmlModFilename()
        {
            return XmlTestFiles.SqlServerCe.XmlModFile;
        }

        protected override string GetXmlRefreshFilename()
        {
            return XmlTestFiles.SqlServerCe.XmlRefreshFile;
        }

        protected override string GetXmlSchemaFilename()
        {
            return XmlTestFiles.SqlServerCe.XmlSchemaFile;
        }

    }
}
